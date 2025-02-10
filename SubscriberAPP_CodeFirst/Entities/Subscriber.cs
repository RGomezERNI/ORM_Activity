using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriberAPP_CodeFirst.Entities;

namespace CodeFirst_Subscriber.Entities
{
    public class Subscriber
    {
        public int SubscriberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string HouseNumber { get; set; }
        public string StreetAddress {  get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateOnly BirthDate { get; set; }
       

        public ICollection<Payment> Payments { get; set; }
        public ICollection<CardDetail>? CardDetails { get; set; }  
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<GoverningOffice> GoverningOffices { get; set; }
        public BillingInfo BillingInfo { get; set; }


    }
}
