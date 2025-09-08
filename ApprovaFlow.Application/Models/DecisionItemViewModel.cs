using ApprovaFlow.Core.Entity;


namespace ApprovaFlow.Application.Models
{
    public class DecisionItemViewModel
    {
        public string RequestDecision { get; set; }

        public DecisionItemViewModel(string requestDecision)
        {
            RequestDecision = requestDecision;
        }
        public static DecisionItemViewModel FromEntity(PurchaseDecision decision)
             => new DecisionItemViewModel(decision.RequestDecision);
    }
}
