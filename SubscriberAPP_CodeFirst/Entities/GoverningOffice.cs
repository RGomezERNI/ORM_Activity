using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Subscriber.Entities;

namespace SubscriberAPP_CodeFirst.Entities
{
    public class GoverningOffice
    {
        public int GoverningOfficeId { get; set; }
        public string OfficeName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Zip {  get; set; }


        public ICollection<Subscriber> Subscribers{ get; set; }
        public ICollection<Subscription> Subscriptions{ get; set; }
    }
}
