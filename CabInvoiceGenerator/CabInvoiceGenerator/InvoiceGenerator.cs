using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        readonly private double distance;
        readonly private double time;
        readonly private double CostPerKiloMeter = 10.0;
        readonly private double CostPerMinitues = 1.0;
        readonly private double MinimumFare = 5.0;

        public InvoiceGenerator(double runningdistance, double runningtime)
        {
            this.distance = runningdistance;
            this.time = runningtime;
        }

        public double CalculateCabFare()
        {
            double totalFare = (distance * CostPerKiloMeter) + (time * CostPerMinitues);
            if (totalFare < MinimumFare)
            {
                return MinimumFare;
            }
            return totalFare;
        }

    }
}
