using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorPattern
{
    public abstract class CondimentDectorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
