using System;
using NUnit.Framework;

namespace TaxCalculator.Tests
{
    class TaxCalculatorAfterFirstYearForExpensiveVehicleTest
    {
        private static readonly DateTime FirstOfApril2017 = new DateTime(2017,4,1);
        private TaxCalculator _taxCalculator;

        [SetUp]
        public void BeforeEach()
        {
            _taxCalculator = new CalculateTax();
        }

        [Test]
        public void WhenVehicleUsesPetrolAndPriceIsOver40K()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.Petrol, FirstOfApril2017, 50000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(450, tax);
        }

        [Test]
        public void WhenVehicleIsElectricAndPriceIsOver40K()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.Electric, FirstOfApril2017, 50000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(310, tax);
        }

        [Test]
        public void WhenVehicleUsesAlternativeFuelAndPriceIsOver40K()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.AlternativeFuel, FirstOfApril2017, 50000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(440, tax);
        }

    }
}
