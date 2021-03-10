using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models;
using Task6.Models.Enums;

namespace Task6.Comparer
{
    public class CarComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as KIndofLightCar;
            var y = second as KIndofLightCar;

            if (x.AirBags > y.AirBags)
            {
                return 1;
            }
            else if (x.AirBags < y.AirBags)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
