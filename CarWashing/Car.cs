using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashing
{
    public class Car : ICar
    {
        public string Model { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
    }
}
