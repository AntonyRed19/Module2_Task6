using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models.Enums;

namespace Task6.Models
{
    public class Ford : KIndofLightCar
    {
        public override KindofLightCar KindofLightCar => KindofLightCar.Pickup;

        public override TypeofBody Body => TypeofBody.OpenBody;

        public override string Name => "Ford";

        public override double Price => 70100;

        public override double Weight => 7600;

        public override Country CreatedCountry => Country.USA;

        public override TypeofGearbox TypeofGearbox => TypeofGearbox.Auto;

        public override int CountofSeats => 2;

        public override int AirBags => 4;

        public override string ModelofCar => "Pickup 2015";

        public override TypeofLight TypeofLightCar => TypeofLight.Trucks;

        public override double FuelConsumption => 13;
    }
}
