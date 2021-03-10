using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models;

namespace Task6.Helpers
{
        public static class CarExtention
        {
            public static KIndofLightCar[] FindCar(this ParkofCars park, double airbugs)
            {
                var temp = new KIndofLightCar[park.Cars.Length];
                for (var i = 0; i < temp.Length; i++)
                {
                    var item = park.Cars[i];
                    if (item.AirBags > airbugs)
                    {
                        temp[i] = park.Cars[i];
                    }
                }

                var tempResult = ArrayHelper.CleanCapacity(temp);
                var result = new KIndofLightCar[tempResult.Length];

                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = tempResult[i] as KIndofLightCar;
                }

                return result;
            }
        }
}
