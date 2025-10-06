
using ApprovaFlow.Core.Entity;

namespace ApprovaFlow.Core.Repositories
{
   public interface IUserRepository
    {
        Task<List<PurchaseRequest>> GetAllRequest();
        Task<PurchaseRequest> GetRequestId(int id);
        Task<List<PurchaseDecision>> GetAllDecisions();
        Task<PurchaseDecision> GetDecisionId(int id);
        Task<int> CreateUser(User user);
        Task UpdateUser( User model);
        Task<User> GetUserById(int id);
        Task<bool> UserExist(int id);
    }
}
