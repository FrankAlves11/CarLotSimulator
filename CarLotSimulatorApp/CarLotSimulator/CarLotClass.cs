using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLotClass
    {
        public static int NumCar = 0;
        public static void IncerementCarValue()
        {
            NumCar++;
        }

        public static int GetNumCars ()
        {
            return NumCar;
        }





    }
}
