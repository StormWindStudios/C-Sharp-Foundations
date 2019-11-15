using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BaseClass<T, U> { }

    class SampleClass<T> : BaseClass<T, string> { }
}
