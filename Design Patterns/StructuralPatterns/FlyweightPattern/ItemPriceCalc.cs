using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FlyweightPattern
{
    public class ItemPriceCalc : IDiscountCalculator
    {
        public double GetDiscountValue(DateTime currentDate, string itemId = null)
        {
            //Call database to calc item discount
            return 0.10;
        }
    }
}
