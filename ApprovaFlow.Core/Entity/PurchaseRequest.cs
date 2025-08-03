using ApprovaFlow.Core.Enum;


namespace ApprovaFlow.Core.Entity
{
    public  class PurchaseRequest
    {
   

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string  RequestDescription { get; private set; }
        public string  RequestTitle { get; private set; }
        public DateTime  DateRequest { get; private set; }
        public StatusRequest Status { get; private set; }
        public User User { get; private set; }
        public bool IsDeleted { get; private set; }


        public PurchaseRequest(int id, int userId, string requestDescription,
            string requestTitle, DateTime dateRequest, string requestDecision,
            DateTime decisionDate)
        {
            Id = id;
            UserId = userId;
            RequestDescription = requestDescription;
            RequestTitle = requestTitle;
            DateRequest = DateTime.Now;
            Status = StatusRequest.PROCESSING;
            IsDeleted = false;
        }


    }
}
