using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Pattern
{
    public class TempEmployee : EmployeePrototype
    {
        public override EmployeePrototype ShallowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }

        public override EmployeePrototype DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            emp = (TempEmployee)this.MemberwiseClone();
            emp.EmpAddress = new Address
            {
                Building = EmpAddress.Building,
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName
            };
            emp.Name = this.Name;
            return emp;
        }
    }
}
