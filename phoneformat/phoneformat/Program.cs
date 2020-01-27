using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneformat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Be: ");
            string be = Console.ReadLine();
            Console.WriteLine(format(be));
            Console.ReadKey(true);
        }

        static string format(string be)
        {
            return "(" + be.Substring(0, 3) + ")" + be.Substring(3, 3) + "-" + be.Substring(6, 4);
        }
    }
}
