using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    class StorebaeltBil:Transportmiddel
    {
        public StorebaeltBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            if (nummerplade.Length<7)
            {
                throw new SystemException("broo for real?");
            }
        }

        public override double Pris()
        {
            if (Brobizz== true && Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return (240 * 0.95)*0.80;
            }
            if (Brobizz== true)
            {
                return 240 * 0.95;
            }
            if (Dato.DayOfWeek == DayOfWeek.Saturday ||Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return 240 * 0.80;
            }
          
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
