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
            InvoiceGenerator invoice = new InvoiceGenerator(5, 2);
            double result = invoice.CalculateCabFare();
            Assert.AreEqual(result, 52);
        }
    }
}