using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[54];
            int szamok_1 = 0;
            int nullak = 0;
            using (StreamReader sr = new StreamReader("szamokfejlecdb.txt", Encoding.UTF8))
            {
                for (int i = 0; i < 54; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());
                    if (tomb[i] >= 15)
                    {
                        szamok_1++;
                    }
                    if (tomb[i] == 0)
                    {
                        nullak++;
                    }
                                        
                }

                Array.Sort(tomb);

                Console.WriteLine($"1.feladat: 15-t elérő számok száma: {szamok_1}");
                Console.WriteLine($"2.feladat: A számok növekvő sorrendben: ");

                foreach (int i in tomb)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"\n3.feladat: A nullák száma: {nullak} db.");
                Console.WriteLine($"4.feladat: A legnagyobb elem: {tomb[53]}");

            }



            Console.ReadKey(true);
        }
    }
}
