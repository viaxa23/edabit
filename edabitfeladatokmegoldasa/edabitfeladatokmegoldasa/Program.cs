using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitfeladatokmegoldasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a stringet: ");
            string bemeno = Console.ReadLine();
            Console.WriteLine($"A csonkolt sztring: {Remove_1(bemeno)}");
            Console.ReadKey(true);   
        }
        static string Remove_1(string bemeno)
        {
            if (bemeno.Length <= 2)
            {
                return bemeno;
            }
            else
            {
                return bemeno.Remove(0, 1).Remove(bemeno.Length -2, 1);
            }
        }
            static string Remove_2(string bemeno)
        {
                if (bemeno.Length <= 2)
                {
                    return bemeno;
                }
                else
                {
                    return bemeno.Substring(1, bemeno.Length-2);
                }

            }
    }
}
