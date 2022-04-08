using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashing
{
    public interface ICar
    {
        string Model { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
