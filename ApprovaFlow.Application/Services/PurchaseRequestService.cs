using ApprovaFlow.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Services
{
    public class PurchaseRequestService
    {
        private readonly IPurchaseRequestRepository _repo;

        public PurchaseRequestService(IPurchaseRequestRepository repo)
        {
            _repo = repo;
        }
    }
}
