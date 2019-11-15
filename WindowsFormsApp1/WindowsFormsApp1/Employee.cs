using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Employee: Person
    {
        protected DateTime HireDate { get; set; }

        public string GetFirst() {
            return base.FirstName;
        }

    }
}
