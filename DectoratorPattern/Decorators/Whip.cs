namespace DectoratorPattern.Decorators
{
    public class Whip : CondimentDectorator
    {
        private readonly Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Whip";

        public override double Cost()
        {
            return .35 + _beverage.Cost();
        }
    }
}
