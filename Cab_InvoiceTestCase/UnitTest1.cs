using NUnit.Framework;
using Cab_Invoice_Generator;

namespace Cab_InvoiceTestCase
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
            double result = invoice.CalculateFare();
            Assert.AreEqual(result, 52);
        }
    }
}