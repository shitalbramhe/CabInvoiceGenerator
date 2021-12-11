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
    }
}
