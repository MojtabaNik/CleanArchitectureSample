// <auto-generated />
using System;
using GhabzeTo.Infra.Data.EF.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    [DbContext(typeof(EfUnitOfWork))]
    [Migration("20190706060549_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GhabzeTo.Domain.Models.Logs.Audit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("KeyValues");

                    b.Property<string>("NewValues");

                    b.Property<string>("OldValues");

                    b.Property<string>("TableName");

                    b.HasKey("Id");

                    b.ToTable("Audit");
                });

            modelBuilder.Entity("GhabzeTo.Domain.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Family");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });
#pragma warning restore 612, 618
        }
    }
}
