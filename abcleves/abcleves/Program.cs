﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcleves
{
    enum Betuk
    {
        a = 1, á, b, c, d, e, é, f, g, h, i, í, j, k, l,
        m, n, o, ó, ö, ő, p, q, r, s, t, u, ú, ü, ű, v, w, x, y, z, ß
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Kérem a szót: ");
            string bemeno = Console.ReadLine();
            Szoveg bemeno = new Szoveg(bemeno);

            Console.WriteLine($"A szó ábécé sorrendben: {Sorrendbe_1(bemeno)}");
            Console.WriteLine($"A szó ábécé sorrendben: {Sorrendbe_2(bemeno)}");
            Console.WriteLine($"A szó ábécé sorrendben: {Sorrendbe_3(bemeno)}");

            Console.ReadKey(true);
        }

        static string Sorrendbe_1(string bemeno)
        {
            char[] tomb = bemeno.ToCharArray();
            Array.Sort(tomb);

            return new String(tomb);
        }

        static string Sorrendbe_2(string bemeno)
        {
            string kimeno = "ß";

            for (int i = 0; i < bemeno.Length; i++)
            {
                Betuk be;
                Enum.TryParse(bemeno[i].ToString(), true, out be);
                for (int j = 0; j < kimeno.Length; j++)
                {
                    Betuk ki;
                    Enum.TryParse(bemeno[i].ToString(), true, out ki);
                    if ((int) be < (int) ki)
                    {
                        kimeno = String.Concat(kimeno.Substring(0, j), bemeno[i], kimeno.Substring(j));
                        break;
                    }

                    kimeno = String.Concat(kimeno, bemeno[i]);
                }
            }

            return kimeno.Substring(0, bemeno.Length);
        }
    }
}
