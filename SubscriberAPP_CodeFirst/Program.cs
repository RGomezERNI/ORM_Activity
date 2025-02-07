using System.Diagnostics;
using CodeFirst_Subscriber.Entities;
using SubscriberAPP_CodeFirst.DbContext;
using SubscriberAPP_CodeFirst.Entities;

using (var context = new SubscriberDbContext())
{
    //creates db if not exists 
    context.Database.EnsureCreated();

    //create entity objects
    var sub = new Subscriber()
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
    };

    context.Subscribers.Add(sub);
    context.SaveChanges();

    var payM = new PaymentMethod()
    {
        PaymentMethodName = "Cash"
    };

    context.PaymentMethods.Add(payM);
    context.SaveChanges();

    var plan = new Plan()
    {
        PlanName = "Basic Plan",
        Price = 29.99f,
        Description = "This plan offers basic features for individual users."
    };

    context.Plans.Add(plan);
    context.SaveChanges();

    var pay = new Payment()
    {
        PaymentDate = new DateOnly(2023, 10, 15),
        PaymentMethodId = 1,
        PlanId = 1,
        SubscriberId=1,
        Status = "Completed"
    };

    context.Payments.Add(pay);
    context.SaveChanges();

    var cardDetails = new CardDetail()
    {
        SubscriberId = 1,
        CardName = "John Doe",
        CardNumber = 1234567812345678, 
        SecurityCode = 123, 
        ExpiryDate = "12/25" 
    };

    context.CardDetails.Add(cardDetails);
    context.SaveChanges();

    var subscription = new Subscription()
    {
        SubscriberId = 1,
        PlanId = 1,
        StartDate = new DateOnly(2023, 10, 1), 
        Status = "Active" 
    };

    context.Subscriptions.Add(subscription);
    context.SaveChanges();
}