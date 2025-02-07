using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Subscriber.Entities;
using Microsoft.EntityFrameworkCore;
using SubscriberAPP_CodeFirst.Entities;


namespace SubscriberAPP_CodeFirst.DbContext
{
    public class SubscriberDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<CardDetail> CardDetails { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer("Server = A-5CG5010L7Q;Database=SubscriberDB;Trusted_connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=SubscriberDB;Trusted_connection=True;TrustServerCertificate=True;");


        }
    }
}
