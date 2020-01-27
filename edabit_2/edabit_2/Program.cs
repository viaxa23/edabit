using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("be: ");
            string be = Console.ReadLine();
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(nletters(be, n));

            Console.ReadKey(true);
        }
        static string nletters(string be, int n)
        {
            if (be != null)
            {
                string kimeno = "";
                for (int j = 0; j < be.Length; j++)
                {
                    bent += be.Substring(j, 1);
                }
            }
            return be;
        }
        else 
        {
            return "üres string";
        }

    }
}
