using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class DecisionViewModel
    {
        public string  RequestDecision { get; set; }

        public DecisionViewModel(string requestDecision)
        {
            RequestDecision = requestDecision;
        }
        public static DecisionViewModel FromEntity(PurchaseDecision decision)
             => new DecisionViewModel(decision.RequestDecision);
    }
}
