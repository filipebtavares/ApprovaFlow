
using ApprovaFlow.Core.Entity;
using ApprovaFlow.Core.Repositories;
using ApprovaFlow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApprovaFlow.Infrastructure.Repositories
{
    public class PurchaseDecisionRepository : IPurchaseDecisionRepository
    {

        private readonly ApprovaFlowDb _context;

        public PurchaseDecisionRepository(ApprovaFlowDb context)
        {
            _context = context;
        }

        public async Task<int> CreateDecision(PurchaseDecision decision)
        {
            _context.PurchaseDecisions.AddAsync(decision);
            await _context.SaveChangesAsync();

            return decision.Id;
        }

        public async Task DeleteDecision(int id)
        {
            await _context.PurchaseDecisions.SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<PurchaseDecision>> GetAllDecision()
        {
            var purchase = await _context.PurchaseDecisions
                .Include(b => b.UserDecision)
                .Include(j => j.PurchaseRequest)
                .ToListAsync();

            return purchase;
        }

        public async Task<PurchaseDecision> GetDecicisonId(int id)
        {
            return await _context.PurchaseDecisions.SingleOrDefaultAsync(j => j.Id == id);
        }

        public Task<bool> PurchaseDecisionExist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateDecision(PurchaseDecision decision)
        {
            _context.Update(decision);
            await _context.SaveChangesAsync();
        }
    }
}
