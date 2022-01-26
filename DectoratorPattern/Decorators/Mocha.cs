using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorPattern.Decorators
{
    public class Mocha : CondimentDectorator
    {
        private readonly Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Mocha";
    }
}
