using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models.Enums;

namespace Task6.Models
{
    public abstract class LightBodyCar : LightCar
    {
        public abstract TypeofBody Body { get; }
    }
}
