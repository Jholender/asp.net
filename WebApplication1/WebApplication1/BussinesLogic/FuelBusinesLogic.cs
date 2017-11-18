using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.BussinesLogic
{
    public class FuelBusinesLogic
    {
        public double CalculateAvgConsumption(int fuel, int distance)
        {
            double avg = ((double)fuel / distance) * 100;
            return avg;

        }
    }
}