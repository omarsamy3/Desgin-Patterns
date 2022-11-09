using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FlyweightPattern
{
    public interface IDiscountCalculator
    {
        double GetDiscountValue(DateTime currentDate, string itemId = null);
    }
}
