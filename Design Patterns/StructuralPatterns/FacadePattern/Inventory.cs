using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.FacadePattern
{
    public class Inventory
    {
        public bool CheckItemQuantity(string itemId, double Quantity) => Quantity < 100;
    }
}
