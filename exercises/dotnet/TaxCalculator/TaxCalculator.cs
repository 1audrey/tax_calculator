using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        protected int Year { get; }
        public abstract int CalculateVehicleTax(Vehicle vehicle);
        protected TaxCalculator() : this(2019)
        {

        }
        protected TaxCalculator(int year)
        {
            Year = year;
        }

    }
}
