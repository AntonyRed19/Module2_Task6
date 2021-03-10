using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Comparer;
using Task6.Helpers;
using Task6.Services;
using Task6.Services.Abstraction;

namespace Task6
{
    public class Starter
    {
        private readonly ICarService _carService;

        public Starter()
        {
            _carService = new CarService();
        }

        public void Run()
        {
            ShowResult();
        }

        public void ShowResult()
        {
            var car = _carService.ParkCar();
            Array.Sort(car.Cars, new CarComparer());

            for (int i = 0; i < car.Cars.Length; i++)
            {
                Console.WriteLine($"Name: {car.Cars[i].Name} Weight: {car.Cars[i].Weight} CountofSeats: {car.Cars[i].CountofSeats}");
            }

            Console.WriteLine($"Car prices: {car.Prices}");

            var cars = car.FindCar(2);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Name: {cars[i].Name} CountofSeats: {cars[i].CountofSeats} Weight: {cars[i].Weight}");
            }
        }
    }
}
