using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Manager: Employee
    {
        private List<Employee> Reports { get; set; }

        public override string ToString()
        {
            return base.FullName;
        }
    }
}
