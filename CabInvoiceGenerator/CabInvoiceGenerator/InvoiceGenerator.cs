using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {

        readonly public double CostPerKiloMeter = 10.0;
        readonly public double CostPerMinitues = 1.0;
        readonly public double MinimumFare = 5.0;

        public double CalculateCabFare(double runningdistance, double runningtime)
        {
            double totalFare = (runningdistance * CostPerKiloMeter) + (runningtime * CostPerMinitues);
            if (totalFare < MinimumFare)
            {
                return MinimumFare;
            }
            return totalFare;
        }
        public double CalculateMultipleCabFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += this.CalculateCabFare(ride.distance, ride.time);
            }
            return totalFare;
        }
    }
}

