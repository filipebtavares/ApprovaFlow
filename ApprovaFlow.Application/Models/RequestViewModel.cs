using ApprovaFlow.Core.Entity;

namespace ApprovaFlow.Application.Models
{
    public class RequestViewModel
    {
        public string  RequestTitle { get; set; }
        public string  RequestDescription { get; set; }

        public RequestViewModel(string requestTitle, string requestDescription)
        {
            RequestTitle = requestTitle;
            RequestDescription = requestDescription;
        }

        public static RequestViewModel FromEntity(PurchaseRequest request)
            => new(request.RequestTitle, request.RequestDescription);
    }
}
