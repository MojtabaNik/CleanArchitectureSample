using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using GhabzeTo.Domain.Core;
using GhabzeTo.Infra.Data.Core.Repositories;
using GhabzeTo.Infra.Data.EF.Uow;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Extensions;

namespace GhabzeTo.Infra.Data.EF.Repositories
{
    public class EfRepositoryBase<TEntity> : EfRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        public EfRepositoryBase(DbContext dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    /// <summary>
    /// Implements IRepository for Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">Type of the Entity for this repository</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key of the entity</typeparam>
    public class EfRepositoryBase<TEntity, TPrimaryKey> : RepositoryBase<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Gets EF DbContext object.
        /// </summary>
        public virtual DbContext Context => _dbContextProvider;

        /// <summary>
        /// Gets DbSet for given entity.
        /// </summary>
        public virtual DbSet<TEntity> Table => Context.Set<TEntity>();

        public virtual DbConnection Connection
        {
            get
            {
                var connection = Context.Database.GetDbConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                return connection;
            }
        }

        private readonly DbContext _dbContextProvider;
        private readonly DbContext _test;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public EfRepositoryBase(DbContext dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;

            //This Config is for zzz.EFExtensions
            EntityFrameworkManager.ContextFactory = _ => _dbContextProvider;
        }

        public override IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public override IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            if (propertySelectors.Length <= 0)
            {
                return GetAll();
            }

            var query = GetAll();

            foreach (var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }

            return query;
        }

        public override async Task<List<TEntity>> GetAllListAsync()
        {
            return await GetAll().ToListAsync().ConfigureAwait(false);
        }

        public override async Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).ToListAsync();
        }

        public override async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().SingleAsync(predicate);
        }

        public override async Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            return await GetAll().FirstOrDefaultAsync(CreateEqualityExpressionForId(id));
        }

        public override async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().FirstOrDefaultAsync(predicate);
        }

        public override TEntity Insert(TEntity entity)
        {
            return Table.Add(entity).Entity;
        }

        public override Task<TEntity> InsertAsync(TEntity entity)
        {
            return Task.FromResult(Insert(entity));
        }

        public override TPrimaryKey InsertAndGetId(TEntity entity)
        {
            entity = Insert(entity);

            if (entity.IsTransient())
            {
                Context.SaveChanges();
            }

            return entity.Id;
        }

        public override async Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity)
        {
            entity = await InsertAsync(entity);

            if (entity.IsTransient())
            {
                await Context.SaveChangesAsync();
            }

            return entity.Id;
        }

        public override TPrimaryKey InsertOrUpdateAndGetId(TEntity entity)
        {
            entity = InsertOrUpdate(entity);

            if (entity.IsTransient())
            {
                Context.SaveChanges();
            }

            return entity.Id;
        }

        public override async Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
        {
            entity = await InsertOrUpdateAsync(entity);

            if (entity.IsTransient())
            {
                await Context.SaveChangesAsync();
            }

            return entity.Id;
        }

        public override TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public override Task<TEntity> UpdateAsync(TEntity entity)
        {
            AttachIfNot(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return Task.FromResult(entity);
        }

        public override void Delete(TEntity entity)
        {
            AttachIfNot(entity);
            Table.Remove(entity);
        }

        public override void Delete(TPrimaryKey id)
        {
            var entity = Table.Local.FirstOrDefault(ent => EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id));
            if (entity == null)
            {
                entity = FirstOrDefault(id);
                if (entity == null)
                {
                    return;
                }
            }

            Delete(entity);
        }

        public override async Task<int> CountAsync()
        {
            return await GetAll().CountAsync();
        }

        public override async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).CountAsync();
        }

        public override async Task<long> LongCountAsync()
        {
            return await GetAll().LongCountAsync();
        }

        public override async Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).LongCountAsync();
        }

        protected virtual void AttachIfNot(TEntity entity)
        {
            if (!Table.Local.Contains(entity))
            {
                Table.Attach(entity);
            }
        }

        public DbContext GetDbContext()
        {
            return Context;
        }

        public Task EnsureCollectionLoadedAsync<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> collectionExpression,
            CancellationToken cancellationToken) where TProperty : class
        {
            var expression = collectionExpression.Body as MemberExpression;
            if (expression == null)
            {
                throw new Exception($"Given {nameof(collectionExpression)} is not a {typeof(MemberExpression).FullName}");
            }

            return Context.Entry(entity)
                .Collection(expression.Member.Name)
                .LoadAsync(cancellationToken);
        }

        public Task EnsurePropertyLoadedAsync<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertyExpression,
            CancellationToken cancellationToken) where TProperty : class
        {
            return Context.Entry(entity).Reference(propertyExpression).LoadAsync(cancellationToken);
        }

        public override void BulkInsert(List<TEntity> entities)
        {
            Context.BulkInsert(entities);
        }

        public override Task BulkInsertAsync(List<TEntity> entities)
        {
            return Context.BulkInsertAsync(entities);
        }
    }
}
