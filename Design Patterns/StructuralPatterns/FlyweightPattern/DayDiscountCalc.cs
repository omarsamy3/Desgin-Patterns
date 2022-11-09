using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FlyweightPattern
{
    public class DayDiscountCalc : IDiscountCalculator
    {
        public double GetDiscountValue(DateTime currentDate, string itemId = null)
        {
            //Call database to calc today discount
            return 0.15;
        }
    }
}
