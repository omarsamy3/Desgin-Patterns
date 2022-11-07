using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.AdapterPattern
{
    public class SalaryAdapter : SalaryCalculator
    {
        private Employee _emp;

        public double CalcSalary(MachineOperator _operator)
        {
            //Lazy loading...
            _emp = new Employee();

            //Adapting the machineoperator to employee be equaling the basicsalary variable.
            _emp.BasicSalary = _operator.BasicSalary;

            //So, we can use the original funciton to calc the salary be passing the adapted employee obj.
            return base.CalcSalary(_emp);
        }
    }
}
