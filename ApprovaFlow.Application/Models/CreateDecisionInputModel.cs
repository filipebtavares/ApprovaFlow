using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class CreateDecisionInputModel
    {
        public string  RequestDecision { get; set; }


        public PurchaseDecision FromEntity()
            => new PurchaseDecision(RequestDecision);
    }
}
