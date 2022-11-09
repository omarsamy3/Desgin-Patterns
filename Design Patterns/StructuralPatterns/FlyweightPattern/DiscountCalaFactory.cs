using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FlyweightPattern
{
    public class DiscountCalaFactory
    {
        public IDiscountCalculator GetDiscountCalc(string calcType)
        {
            IDiscountCalculator discountCalc = null;

            //Make a dictionary to contain the data I want in memory to get if i need, not to initialize again.
            var calcList = new Dictionary<string, IDiscountCalculator>();
            if (calcList.ContainsKey(calcType))
            {
                return calcList[calcType]; //Then break...
            }

            switch (calcType)
            {
                case "day":
                    discountCalc = new DayDiscountCalc();
                    calcList.Add("day", discountCalc);
                    break;

                case "item":
                    discountCalc = new ItemPriceCalc();
                    calcList.Add("item", discountCalc);
                    break;
            }

            return discountCalc;
        }
    }
}
