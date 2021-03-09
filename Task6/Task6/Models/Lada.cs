using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models.Enums;

namespace Task6.Models
{
    public class Lada : KIndofLightCar
    {
        public override KindofLightCar KindofLightCar => KindofLightCar.Sedan;

        public override TypeofBody Body => TypeofBody.CloseBody;

        public override string Name => "Lada";

        public override double Price => 15500;

        public override double Weight => 3000;

        public override Country CreatedCountry => Country.Russia;

        public override TypeofGearbox TypeofGearbox => TypeofGearbox.Mechanical;

        public override int CountofSeats => 4;

        public override int AirBags => 0;

        public override string ModelofCar => "99";

        public override TypeofLight TypeofLightCar => TypeofLight.Passenger;
    }
}
