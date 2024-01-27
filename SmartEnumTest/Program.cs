using SmartEnum;

var subscription = Subscription.FromValue(3);

Console.WriteLine($"Discount for {subscription} is {subscription.Discount:P}");

Console.ReadKey();