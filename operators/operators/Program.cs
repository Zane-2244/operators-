using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 2;
            var c = 4;
            Console.WriteLine(!(c > b || c == a));
        }
    }
}
