    using System;
    using Microsoft.EntityFrameworkCore;

    namespace WorkshopXamarinFormsApi.DataContext
    {
        public partial class BranchesContext : DbContext
        {

            public virtual DbSet<Branch> Branches { get; set; }

            public BranchesContext(DbContextOptions<BranchesContext> options)
                : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {


                modelBuilder.Entity<Branch>(entity =>
                {
                    entity.Property(e => e.Location)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Name)
                        .HasMaxLength(100)
                        .IsUnicode(false);
                    entity.Property(e => e.BranchId)
                    .ValueGeneratedOnAdd();
                });

                

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
