using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Contractor: Person
    {
        private DateTime StartDate { get; set; }

        private DateTime EndDate { get; set; }

        public void GetManager() {
            Manager mgr = new Manager();            
        }
    }
}
