using System;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public static class Weekend
    {
        public static double PrisWeekendRabat(Bil bil)
        {
            if (bil.Dato.DayOfWeek == (DayOfWeek) 6 | bil.Dato.DayOfWeek == 0)
            {
                return (bil.Pris() * 0.80);
            }
            return bil.Pris();
        }
    }
}
