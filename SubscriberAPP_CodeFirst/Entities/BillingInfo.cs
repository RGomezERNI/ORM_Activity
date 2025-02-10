using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Subscriber.Entities;

namespace SubscriberAPP_CodeFirst.Entities
{
    public class BillingInfo
    {
        public int BillingInfoId { get; set; }
        public string BillingCycle { get; set; }
        public DateOnly LastBilledDate { get; set; }


        public Subscriber Subscriber { get; set; }
        public int SubscriberId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }
    }
}
