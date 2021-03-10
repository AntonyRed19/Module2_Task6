using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models;
using Task6.Services.Abstraction;

namespace Task6.Services
{
    public class CarService : ICarService
    {
        public CarService()
        {
        }

        public ParkofCars ParkCar()
        {
            var cars = new KIndofLightCar[]
            {
                new Lada(),
                new Bmv(),
                new Ford(),
            };
            var price = 0d;
            for (var i = 0; i < cars.Length; i++)
            {
                price += cars[i].Price;
            }

            return new ParkofCars { Cars = cars, Prices = price };
        }
    }
}
