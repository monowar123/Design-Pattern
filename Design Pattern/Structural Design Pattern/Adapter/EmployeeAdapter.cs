using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Adapter
{
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget   //--Class adapter
    {
        //--Object adapter
        //ThirdPartyBillingSystem thirdPartyBillingSystem;

        public EmployeeAdapter()
        {
            //--Object adapter
            //thirdPartyBillingSystem = new ThirdPartyBillingSystem();
        }
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> employeeList = new List<Employee>();

            for(int i =0; i< employeesArray.GetLength(0); i++)
            {
                Id = employeesArray[i, 0];
                Name = employeesArray[i, 1];
                Designation = employeesArray[i, 2];
                Salary = employeesArray[i, 3];

                employeeList.Add(new Employee(
                    Convert.ToInt32(Id),
                    Name,
                    Designation,
                    Convert.ToDecimal(Salary)
                    ));
            }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee");

            Console.WriteLine("Deligate to the ThirdPartyBillingSystem to process employee salary");

            //--Object adapter
            //thirdPartyBillingSystem.ProcessSalary(employeeList);

            //--Class adapter
            ProcessSalary(employeeList);
        }


    }
}
