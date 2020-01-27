using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneformat
{
    class telefonszam
    {
        public int[] Telefon { get; set; }

        public telefonszam(int[] telefon)
        {
            this.Telefon = telefon;
        }

        public string Telefonszam()
        {
            string kimeno = "";

            for (int i = 0; i < this.Telefon.Length; i++)
            {
                kimeno = String.Concat(kimeno, this.Telefon[i]);

            }

            kimeno = String.Concat("(", kimeno.Substring(0, 3), ")", kimeno.Substring(3, 3), "-", kimeno.Substring(6));
            return kimeno;
        }
    }
}
