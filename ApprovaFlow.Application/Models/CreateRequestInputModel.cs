using ApprovaFlow.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class CreateRequestInputModel
    {
        public int  UserId { get; set; }
        public string  RequestDescription { get; set; }
        public string  Title { get; set; }
        

        public PurchaseRequest FromEntity()
            => new PurchaseRequest(UserId, RequestDescription, Title);
    }
}
