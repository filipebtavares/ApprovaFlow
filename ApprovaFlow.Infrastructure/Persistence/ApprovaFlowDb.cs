
using ApprovaFlow.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApprovaFlow.Infrastructure.Persistence
{
    public  class ApprovaFlowDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PurchaseDecision> PurchaseDecisions { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>(e =>
            {

            });
                
            base.OnModelCreating(model);
        }
    }
}
