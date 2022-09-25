using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    //Concrete Builder
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
            product.Add($"Car Model name:{this.brandName}");
        }
        public void AddHeadlights()
        {
            product.Add("Headlights are added");
        }

        public void InsertWheels()
        {
            product.Add("Wheel are added");
        }
        public void BuildBody()
        {
            product.Add("Body of car was added");
        }

        public void EndOperations()
        {
             //End Operation}
        }

        public Product GetVehicle()
        {
            return product;
        }


    }
}
