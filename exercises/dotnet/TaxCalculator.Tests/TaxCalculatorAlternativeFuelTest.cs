using System;
using NUnit.Framework;

namespace TaxCalculator.Tests
{
   
    class TaxCalculatorAlternativeFuelTest
    {
        private static readonly DateTime FirstOfJanuary2019 = new DateTime(2019, 1, 1);
        private TaxCalculator _taxCalculator;

        [SetUp]
        public void BeforeEach()
        {
            _taxCalculator = new CalculateTax();
        }

        [Test]
        public void WhenVehicleHas0GramsCo2()
        {
            Vehicle vehicle = new Vehicle(0, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(0, tax);
        }

        [Test]
        public void WhenVehicleHas50GramsCo2()
        {
            Vehicle vehicle = new Vehicle(50, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(0, tax);
        }

        [Test]
        public void WhenVehicleHas75GramsCo2()
        {
            Vehicle vehicle = new Vehicle(75, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(15, tax);
        }

        [Test]
        public void WhenVehicleHas90GramsCo2()
        {
            Vehicle vehicle = new Vehicle(90, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(95, tax);
        }

        [Test]
        public void WhenVehicleHas100GramsCo2()
        {
            Vehicle vehicle = new Vehicle(100, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(115, tax);
        }

        [Test]
        public void WhenVehicleHas110GramsCo2()
        {
            Vehicle vehicle = new Vehicle(110, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(135, tax);
        }

        [Test]
        public void WhenVehicleHas130GramsCo2()
        {
            Vehicle vehicle = new Vehicle(130, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(155, tax);
        }

        [Test]
        public void WhenVehicleHas150GramsCo2()
        {
            Vehicle vehicle = new Vehicle(150, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(195, tax);
        }

        [Test]
        public void WhenVehicleHas170GramsCo2()
        {
            Vehicle vehicle = new Vehicle(170, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(505, tax);
        }

        [Test]
        public void WhenVehicleHas190GramsCo2()
        {
            Vehicle vehicle = new Vehicle(190, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(820, tax);
        }

        [Test]
        public void WhenVehicleHas225GramsCo2()
        {
            Vehicle vehicle = new Vehicle(225, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(1230, tax);
        }

        [Test]
        public void WhenVehicleHas255GramsCo2()
        {
            Vehicle vehicle = new Vehicle(255, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(1750, tax);
        }

        [Test]
        public void WhenVehicleHasOver255GramsCo2()
        {
            Vehicle vehicle = new Vehicle(256, FuelType.AlternativeFuel, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(2060, tax);
        }

        [Test]
        public void WhenVehicleIsElectric()
        {
            Vehicle vehicle = new Vehicle(0, FuelType.Electric, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateVehicleTax(vehicle);
            Assert.AreEqual(0, tax);
        }
    }
}
