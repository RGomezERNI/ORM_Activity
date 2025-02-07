using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriberAPP_CodeFirst.Entities;

namespace CodeFirst_Subscriber.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
