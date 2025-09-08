
using ApprovaFlow.Core.Entity;
using ApprovaFlow.Core.Repositories;
using ApprovaFlow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApprovaFlow.Infrastructure.Repositories
{
    public class PurchaseRequestRepository : IPurchaseRequestRepository
    {

        private readonly ApprovaFlowDb _context;

        public PurchaseRequestRepository(ApprovaFlowDb context)
        {
            _context = context;
        }
        public async Task DeleteRequest(int id)
        {
             await _context.PurchaseRequests.SingleOrDefaultAsync(j => j.Id == id);
        }

        public async Task<List<PurchaseRequest>> GetAllRequest()
        {
            var purchase = await _context.PurchaseRequests
                .Include(g => g.PurchaseDecision)
                .Include(f => f.User)
                .ToListAsync();

            return purchase;
        }

        public async Task<PurchaseRequest> GetRequestId(int id)
        {
            return await _context.PurchaseRequests.SingleOrDefaultAsync(n => n.Id == id);
        }

        public Task<bool> PurchaseRequestExist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
