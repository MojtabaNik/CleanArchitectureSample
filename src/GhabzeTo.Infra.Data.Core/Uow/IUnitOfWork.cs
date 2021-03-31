using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GhabzeTo.Infra.Data.Core.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges(bool acceptAllChangesOnSuccess);

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = new CancellationToken());

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

        void BulkSaveChange();
        Task BulkSaveChangeAsync();

        string GetConnectionString();
    }
}
