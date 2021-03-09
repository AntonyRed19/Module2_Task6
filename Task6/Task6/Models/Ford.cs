using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Models
{
    class Ford
    {
        public override KindofLightCar KindofLightCar => KindofLightCar.Сabriolet;

        public override TypeofBody Body => TypeofBody.OpenBody;

        public override string Name => "Bmv";

        public override double Price => 41100;

        public override double Weight => 4000;

        public override Country CreatedCountry => Country.Germany;

        public override TypeofGearbox TypeofGearbox => TypeofGearbox.Auto;

        public override int CountofSeats => 2;

        public override int AirBags => 4;

        public override string MarkOfCar => "Bmv";

        public override string ModelofCar => "Hardtop 2007";

        public override TypeofLight TypeofLightCar => TypeofLight.Passenger;
    }
}
