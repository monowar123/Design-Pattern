using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
