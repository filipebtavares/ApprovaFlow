
using ApprovaFlow.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApprovaFlow.Infrastructure.Persistence
{
    public  class ApprovaFlowDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PurchaseDecision> PurchaseDecisions { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }

        public ApprovaFlowDb(DbContextOptions<ApprovaFlowDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(e =>
            {
                e.HasKey(k => k.Id);


                e.HasMany(j => j.PurchaseRequests)
                .WithOne(u => u.User)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<PurchaseRequest>(e =>
            {
                e.HasKey(j => j.Id);

                e.HasOne(p => p.PurchaseDecision)
                    .WithOne(o => o.PurchaseRequest)
                    .HasForeignKey<PurchaseDecision>(fk => fk.RequestId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<PurchaseDecision>(e =>
            {
                e.HasKey(r => r.Id);

                e.HasOne(u => u.UserDecision)
                    .WithMany(pd => pd.PurchaseDecisions)
                    .HasForeignKey(j => j.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
                
            base.OnModelCreating(builder);
        }
    }
}
