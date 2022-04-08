using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashing
{
    public interface ICarWasher
    {
        string MakeWashingService();
        void AddCar(ICar car);
        void AddCars(IEnumerable<ICar> cars);
    }
}
