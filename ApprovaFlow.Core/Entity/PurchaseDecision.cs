using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Core.Entity
{
    public  class PurchaseDecision
    {
       

        public int Id { get; private set; }
        public User UserDecision { get; private set; }
        public int UserId { get; private set; }
        public int RequestId { get; private set; }
        public PurchaseRequest PurchaseRequest { get; private set; }
        public string  RequestDecision { get; private set; }
        public DateTime DecisionDate { get; private set; }
        public  bool IsDeleted { get; private set; }

        public PurchaseDecision(int id, PurchaseRequest purchaseRequest, string requestDecision, DateTime decisionDate)
        {
            Id = id;
            PurchaseRequest = purchaseRequest;
            RequestDecision = requestDecision;
            DecisionDate = DateTime.Now;
            IsDeleted = false;
        }


        public void SetAsDeleted()
        {
            IsDeleted = true;
        }

        public void UpdateDecision(string requestDecision)
        {
            RequestDecision = requestDecision;
        }
    }
}
