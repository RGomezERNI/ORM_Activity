using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriberAPP_CodeFirst.Entities;

namespace CodeFirst_Subscriber.Entities
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }

        public ICollection<Payment> Payments{ get; set; }
        public ICollection<BillingInfo> BillingInfos { get; set; }

    }

}
