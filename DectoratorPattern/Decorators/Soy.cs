using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorPattern.Decorators
{
    public class Soy : CondimentDectorator
    {
        private readonly Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost()
        {
            return .25 + _beverage.Cost();
        }
    }
}
