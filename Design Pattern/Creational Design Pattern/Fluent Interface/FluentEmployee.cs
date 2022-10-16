using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Fluent_Interface
{
    public class FluentEmployee : Employee
    {
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            this.FullName = FullName;
            return this;
        }

        public FluentEmployee Born(string DateOfBirth)
        {
            this.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }

        public FluentEmployee WorkingOn(string Department)
        {
            this.Department = Department;
            return this;
        }

        public FluentEmployee StaysAt(string Address)
        {
            this.Address = Address;
            return this;
        }
    }

    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }
}
