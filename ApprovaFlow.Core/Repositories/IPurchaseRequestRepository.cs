using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Core.Repositories
{
    public interface IPurchaseRequestRepository
    {
        Task<List<PurchaseRequest>> GetAllRequest();
        Task<PurchaseRequest> GetRequestId(int id);
        Task DeleteRequest(int id);
        Task<bool> PurchaseRequestExist(int id);
    }
}
