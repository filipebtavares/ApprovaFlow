using ApprovaFlow.Application.Models;
using ApprovaFlow.Core.Repositories;


namespace ApprovaFlow.Application.Services
{
    public class PurchaseDecisionService
    {
        private readonly IPurchaseDecisionRepository _repo;

        public PurchaseDecisionService(IPurchaseDecisionRepository repo)
        {
            _repo = repo;
        }

       
    }
}
