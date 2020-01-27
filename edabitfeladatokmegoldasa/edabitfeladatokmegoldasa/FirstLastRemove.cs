using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitfeladatokmegoldasa
{
    class FirstLastRemove
    {
        public string Bemeno { get; set; }

        public FirstLastRemove(String bemeno)
        {
            this.Bemeno = bemeno;
        }

        public string Remove_1()
        {
            if (Bemeno.Length <= 2)
            {
                return Bemeno;
            }
            else
            {
                return Bemeno.Remove(0, 1).Remove(Bemeno.Length - 2, 1);
            }
        }
        public string Remove_2()
        {
            if (Bemeno.Length <= 2)
            {
                return Bemeno;
            }
            else
            {
                return Bemeno.Substring(1, Bemeno.Length - 2);
            }

        }
    }
}
