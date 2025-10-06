using ApprovaFlow.Core.Entity;
using ApprovaFlow.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public class RequestItemViewModel
    {
        public string  RequestTitle { get; set; }
        public string  RequestDescription { get; set; }
        public string  FullName { get; set; }
        public StatusRequest Status { get; set; }

        public RequestItemViewModel(string requestTitle, string requestDescription, string fullName, StatusRequest status)
        {
            RequestTitle = requestTitle;
            RequestDescription = requestDescription;
            FullName = fullName;
            Status = status;
        }

        public static RequestItemViewModel FromEntity(PurchaseRequest request)
            => new RequestItemViewModel(request.RequestTitle, request.RequestDescription, request.User.FullName
                ,request.Status);
    }
}
