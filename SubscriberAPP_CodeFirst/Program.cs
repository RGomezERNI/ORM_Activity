using System.Diagnostics;
using CodeFirst_Subscriber.Entities;
using SubscriberAPP_CodeFirst.DbContext;
using SubscriberAPP_CodeFirst.Entities;

using (var context = new SubscriberDbContext())
{
    //creates db if not exists 
    context.Database.EnsureCreated();

    var subscribers = new List<Subscriber>
    {
        new Subscriber
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Phone = "555-1234",
            HouseNumber = "123",
            StreetAddress = "Main St",
            City = "Springfield",
            ZipCode = "12345",
            BirthDate = new DateOnly(1990, 5, 20)
        },
        new Subscriber
        {
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com",
            Phone = "555-5678",
            HouseNumber = "456",
            StreetAddress = "Second St",
            City = "Springfield",
            ZipCode = "12345",
            BirthDate = new DateOnly(1992, 8, 15)
        },
        new Subscriber
        {
            FirstName = "Alice",
            LastName = "Johnson",
            Email = "alice.johnson@example.com",
            Phone = "555-8765",
            HouseNumber = "789",
            StreetAddress = "Third St",
            City = "Springfield",
            ZipCode = "12345",
            BirthDate = new DateOnly(1985, 3, 30)
        }
    };

    // Create multiple Governing Offices
    var offices = new List<GoverningOffice>
    {
        new GoverningOffice
        {
            OfficeName = "Main Office",
            StreetAddress = "456 Office St",
            City = "Springfield",
            Zip = "12345"
        },
        new GoverningOffice
        {
            OfficeName = "Branch Office",
            StreetAddress = "789 Branch St",
            City = "Springfield",
            Zip = "12345"
        }
    };

    context.GoverningOffices.AddRange(offices);
    context.SaveChanges();

    context.Subscribers.AddRange(subscribers);
    context.SaveChanges();

    // Create multiple Payment Methods
    var paymentMethods = new List<PaymentMethod>
    {
        new PaymentMethod { PaymentMethodName = "Cash" },
        new PaymentMethod { PaymentMethodName = "Credit Card" },
        new PaymentMethod { PaymentMethodName = "PayPal" }
    };

    context.PaymentMethods.AddRange(paymentMethods);
    context.SaveChanges();

    // Create multiple Plans
    var plans = new List<Plan>
    {
        new Plan
        {
            PlanName = "Basic Plan",
            Price = 29.99f,
            Description = "This plan offers basic features for individual users."
        },
        new Plan
        {
            PlanName = "Standard Plan",
            Price = 49.99f,
            Description = "This plan offers standard features for families."
        },
        new Plan
        {
            PlanName = "Premium Plan",
            Price = 79.99f,
            Description = "This plan offers premium features for power users."
        }
    };

    context.Plans.AddRange(plans);
    context.SaveChanges();

    // Create multiple Payments
    var payments = new List<Payment>
    {
        new Payment
        {
            PaymentDate = new DateOnly(2023, 10, 15),
            PaymentMethodId = paymentMethods[0].PaymentMethodId, 
            PlanId = plans[0].PlanId, 
            SubscriberId = subscribers[0].SubscriberId, 
            Status = "Completed"
        },
        new Payment
        {
            PaymentDate = new DateOnly(2023, 10, 16),
            PaymentMethodId = paymentMethods[1].PaymentMethodId, 
            PlanId = plans[1].PlanId, 
            SubscriberId = subscribers[1].SubscriberId, 
            Status = "Completed"
        },
        new Payment
        {
            PaymentDate = new DateOnly(2023, 10, 17),
            PaymentMethodId = paymentMethods[2].PaymentMethodId, 
            PlanId = plans[2].PlanId, 
            SubscriberId = subscribers[2].SubscriberId, 
            Status = "Pending"
        }
    };

    context.Payments.AddRange(payments);
    context.SaveChanges();
  
    // Create multiple Card Details for Subscribers
    var cardDetailsList = new List<CardDetail>
    {
        new CardDetail
        {
            SubscriberId = subscribers[0].SubscriberId, 
            CardName = "John Doe",
            CardNumber = 1234567812345678,
            SecurityCode = 123,
            ExpiryDate = "12/25"
        },
        new CardDetail
        {
            SubscriberId = subscribers[1].SubscriberId, 
            CardName = "Jane Smith",
            CardNumber = 2345678923456789,
            SecurityCode = 456,
            ExpiryDate = "11/24"
        },
        new CardDetail
        {
            SubscriberId = subscribers[2].SubscriberId, 
            CardName = "Alice Johnson",
            CardNumber = 3456789034567890,
            SecurityCode = 789,
            ExpiryDate = "10/23"
        }
    };

    context.CardDetails.AddRange(cardDetailsList);
    context.SaveChanges();


    // Create multiple Subscriptions for Subscribers
    var subscriptions = new List<Subscription>
    {
        new Subscription
        {
            SubscriberId = subscribers[0].SubscriberId, 
            PlanId = plans[0].PlanId, 
            GoverningOfficeId = offices[0].GoverningOfficeId, 
            StartDate = new DateOnly(2023, 10, 1),
            Status = "Active"
        },
        new Subscription
        {
            SubscriberId = subscribers[1].SubscriberId, 
            PlanId = plans[1].PlanId, 
            GoverningOfficeId = offices[1].GoverningOfficeId, 
            StartDate = new DateOnly(2023, 10, 2),
            Status = "Active"
        },
        new Subscription
        {
            SubscriberId = subscribers[2].SubscriberId, 
            PlanId = plans[2].PlanId, 
            GoverningOfficeId = offices[0].GoverningOfficeId, 
            StartDate = new DateOnly(2023, 10, 3),
            Status = "Inactive"
        }
    };

    context.Subscriptions.AddRange(subscriptions);
    context.SaveChanges();

   

}