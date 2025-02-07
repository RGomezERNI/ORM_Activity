using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Subscriber.Entities;

namespace SubscriberAPP_CodeFirst.Entities
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int SubscriberId { get; set; }
        public int PlanId { get; set; }
        public DateOnly StartDate { get; set; }
        public string Status {  get; set; }
        
        public Subscriber Subscriber { get; set; }
        public Plan Plan { get; set; } 
    }
}
