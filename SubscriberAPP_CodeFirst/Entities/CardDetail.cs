using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Subscriber.Entities;

namespace SubscriberAPP_CodeFirst.Entities
{
    public class CardDetail
    {
        public int CardDetailId {  get; set; }
        public int SubscriberId { get; set; }
        public string CardName { get; set; }
        public long CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public string ExpiryDate { get; set; }

        public Subscriber Subscriber { get; set; }

    }
}
