using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models.Enums;

namespace Task6.Models
{
    public abstract class Car
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
        public abstract double Weight { get; }
        public abstract string CreatedCountry { get; }
        public TypeofGearbox TypeofGearbox { get; }

        public int CountofSeats { get; }

        public int AirBags { get; }
        public string MarkOfCar { get; }
        public string ModelofCar { get; }
    }
}
