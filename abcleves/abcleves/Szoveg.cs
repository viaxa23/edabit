using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcleves
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
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
                    if ((int)be < (int)ki)
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
