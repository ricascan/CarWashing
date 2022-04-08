using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashing
{
    public class ManualCarWasher : CarWasher
    {
        protected override string Wash(List<ICar> cars)
        {
            StringBuilder outputText = new();
            cars.ForEach(c => outputText.AppendLine($"Manual washing of car {c.Model} has been performed with hot water and soap."));
            return outputText.ToString();
        }
    }
}
