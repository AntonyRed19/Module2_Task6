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
        public abstract Country CreatedCountry { get; }
        public abstract TypeofGearbox TypeofGearbox { get; }

        public abstract int CountofSeats { get; }

        public abstract int AirBags { get; }
        public abstract string MarkOfCar { get; }
        public abstract string ModelofCar { get; }
    }
}
