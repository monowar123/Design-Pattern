using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Adapter
{
    public class ThirdPartyBillingSystem
    {
        //To process salary we are using 3rd party billing system which take input only list of employee
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach(Employee employee in listEmployee)
            {
                Console.WriteLine("BDT " + employee.Salary + " Salary credited to " + employee.Name + " account");
            }
        }
    }
}
