using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person: IPerson
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FirstName + " " + _LastName;
            }
        }

        public HomeCoords Home {
            get {
                HomeCoords _Home;
                _Home.x = 10;
                _Home.y = 10;
                return _Home;
            }
        }

        public Person() {
            _FirstName = "Joe";
            _LastName = "Jorden";
        }

        public static DateTime GetDOB() {
            return DateTime.Now.Subtract(new TimeSpan(7300, 0, 0, 0, 0));
        }

        public override string ToString()
        {
            return _FirstName + " " + _LastName;
        }
    }
}
