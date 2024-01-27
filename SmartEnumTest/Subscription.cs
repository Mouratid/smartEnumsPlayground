namespace SmartEnum;

public abstract class Subscription : Enumeration<Subscription>
{
    public static readonly Subscription Standard = new StandardSubscription();
    public static readonly Subscription Premium = new PremiumSubscription();
    public static readonly Subscription Platinum = new PlatinumSubscription();

    protected Subscription(int value, string name)
        : base(value, name) 
    { }

    public abstract double Discount { get; }

    private sealed class StandardSubscription : Subscription
    {
        public StandardSubscription()
            : base(1, "Standard")
        { }

        public override double Discount => 0.01;
    }

    private sealed class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
            : base(2, "Premium")
        { }

        public override double Discount => 0.05;
    }

    private sealed class PlatinumSubscription : Subscription
    {
        public PlatinumSubscription()
            : base(3, "Platinum")
        { }

        public override double Discount => 0.1;
    }
}
