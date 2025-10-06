using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Core.Repositories
{
    public interface IPurchaseDecisionRepository
    {
        Task<List<PurchaseDecision>> GetAllDecision();
        Task<PurchaseDecision> GetDecicisonId(int id);
        Task<int> CreateDecision(PurchaseDecision decision);
        Task DeleteDecision(int id);
        Task UpdateDecision(PurchaseDecision decision);
        Task<bool> PurchaseDecisionExist(int id);
    }
}
