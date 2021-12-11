using CabInvoiceGenerator;
using NUnit.Framework;

namespace Testproject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateCabFare(5, 2);
            Assert.AreEqual(result, 52);
        }

        [Test]
        public void GivenDistanceAndTime_MultipleRide_WhenCalculate_ShouldReturnTotalFare()
        {
            Ride[] rides = { new Ride(4.0, 2.0), new Ride(6.0, 3.0) };
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateMultipleCabFare(rides);
            Assert.AreEqual(result, 105);
        }
        [Test]
        public void GivenSummary_WhenCalculate_ShouldReturnAverageFare()
        {
            Ride[] rides = { new Ride(7.0, 3), new Ride(6.5, 4) };
            InvoiceGenerator invoice = new InvoiceGenerator();
            InvoiceSummary summary = new InvoiceSummary();
            InvoiceSummary result = invoice.CalculateInvoiceSummary(rides);
            summary.totalFare = 142;
            summary.totalNumberOfRides = 2;
            summary.CalulateAverageFare();
            if (result.totalFare == summary.totalFare && result.totalNumberOfRides == summary.totalNumberOfRides && result.averageFarePerRide == summary.averageFarePerRide)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
