using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashing
{
    public class CarWasherFactory
    {
        public static ICarWasher GetCarWasher(WashingTypes carWasherType)
        {
            return carWasherType switch
            {
                WashingTypes.Manual => new ManualCarWasher(),
                WashingTypes.Automatic => new AutomaticCarWasher(),
                _ => throw new InvalidOperationException("Car washer type does not exist."),
            };
        }
    }

    public enum WashingTypes
    {
        Manual, Automatic
    }
}
