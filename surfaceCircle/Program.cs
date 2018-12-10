using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surfaceCircle
{
    delegate double Result(int n);
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            const double PI = 3.14;

            Result surface = num => (num * num) * PI;

            Console.WriteLine("Enter integer value of your circle radius");
            n = surface(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The sruface of your circle is {0}", n);
            Console.Read();
        }
    }
}
