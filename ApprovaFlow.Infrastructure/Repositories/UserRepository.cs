
using ApprovaFlow.Application.Models;
using ApprovaFlow.Core.Entity;
using ApprovaFlow.Core.Repositories;
using ApprovaFlow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApprovaFlow.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApprovaFlowDb _context;

        public UserRepository(ApprovaFlowDb context)
        {
            _context = context;
        }

        public async Task<int> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<List<PurchaseDecision>> GetAllDecisions()
        {
            var decisions = await _context.PurchaseDecisions.
                Include(j => j.UserDecision)
                .Include(n => n.RequestDecision)
                .Include(b => b.DecisionDate)
                .ToListAsync();

            return decisions;
        }

        public async Task<List<PurchaseRequest>> GetAllRequest()
        {
            var request = await _context.PurchaseRequests.ToListAsync();

            return request;
        }

        public async Task<PurchaseDecision> GetDecisionId(int id)
        {
            var decisions = await _context.PurchaseDecisions.SingleOrDefaultAsync(j => j.Id == id);

            if (decisions is null)
            {
                return ResultViewModel<DecisionItemViewModel>.Error("Essa decisçaõ não pode ser encotrada");
            }


        }

        public async Task<PurchaseRequest> GetRequestId(int id)
        {
            return await _context.PurchaseRequests.SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateUser( User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public Task<bool> UserExist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
