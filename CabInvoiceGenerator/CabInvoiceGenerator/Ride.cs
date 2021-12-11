using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        readonly public double distance;
        readonly public double time;
        public Ride(double runningdistance, double runningtime)
        {
            this.distance = runningdistance;
            this.time = runningtime;
        }
    }
}
