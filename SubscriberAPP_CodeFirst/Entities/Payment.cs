

namespace CodeFirst_Subscriber.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int SubscriberId { get; set; }
        public int PaymentMethodId { get; set; }
        public int PlanId { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string Status { get; set; }

        //FKeys
        public Subscriber Subscriber { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Plan Plan { get; set; }

    }
}
