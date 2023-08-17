using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FirstProject.Common
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public static void Update(Employee employee)
        {
            employee.Name = "vamsi";
            employee.Id = 559;
        }
    }
    
}
