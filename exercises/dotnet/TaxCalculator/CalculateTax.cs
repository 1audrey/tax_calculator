using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class CalculateTax : TaxCalculator
    {
        public override int CalculateVehicleTax(Vehicle vehicle)
        {
            if (vehicle.FuelType == FuelType.Petrol)
            {
                if (vehicle.Co2Emissions == 0)
                {
                    return 0;
                }
                else if (vehicle.Co2Emissions <= 50)
                {
                    return 10;
                }
                else if (vehicle.Co2Emissions <= 75)
                {
                    return 25;
                }
                else if (vehicle.Co2Emissions <= 90)
                {
                    return 105;
                }
                else if (vehicle.Co2Emissions <= 100)
                {
                    return 125;
                }
                else if (vehicle.Co2Emissions <= 110)
                {
                    return 145;
                }
                else if (vehicle.Co2Emissions <= 130)
                {
                    return 165;
                }
                else if (vehicle.Co2Emissions <= 150)
                {
                    return 205;
                }
                else if (vehicle.Co2Emissions <= 170)
                {
                    return 515;
                }
                else if (vehicle.Co2Emissions <= 190)
                {
                    return 830;
                }
                else if (vehicle.Co2Emissions <= 225)
                {
                    return 1240;
                }
                else if (vehicle.Co2Emissions <= 255)
                {
                    return 1760;
                }
                else
                    return 2070;
            }

         
            if(vehicle.FuelType == FuelType.Diesel)

            {
                if (vehicle.Co2Emissions == 0)
                {
                    return 0;
                }
                else if (vehicle.Co2Emissions <= 50)
                {
                 return 25;
                }
                else if (vehicle.Co2Emissions <= 75)
                {
                    return 105;
                }
                else if (vehicle.Co2Emissions <= 90)
                {
                    return 125;
                }
                else if (vehicle.Co2Emissions <= 100)
                {
                    return 145;
                }
                else if (vehicle.Co2Emissions <= 110)
                {
                    return 165;
                }
                else if (vehicle.Co2Emissions <= 130)
                {
                    return 205;
                }
                else if (vehicle.Co2Emissions <= 150)
                {
                    return 515;
                }
                else if (vehicle.Co2Emissions <= 170)
                {
                    return 830;
                }
                else if (vehicle.Co2Emissions <= 190)
                {
                    return 1240;
                }
                else if (vehicle.Co2Emissions <= 225)
                {
                    return 1760;
                }
                else
                    return 2070;
            }

          if(vehicle.FuelType == FuelType.AlternativeFuel)
          {
           if (vehicle.Co2Emissions == 0)
                {
                    return 0;
                }
                else if (vehicle.Co2Emissions <= 50)
                {
                    return 0;
                }
                else if (vehicle.Co2Emissions <= 75)
                {
                    return 15;
                }
                else if (vehicle.Co2Emissions <= 90)
                {
                    return 95;
                }
                else if (vehicle.Co2Emissions <= 100)
                {
                    return 115;
                }
                else if (vehicle.Co2Emissions <= 110)
                {
                    return 135;
                }
                else if (vehicle.Co2Emissions <= 130)
                {
                    return 155;
                }
                else if (vehicle.Co2Emissions <= 150)
                {
                    return 195;
                }
                else if (vehicle.Co2Emissions <= 170)
                {
                    return 505;
                }
                else if (vehicle.Co2Emissions <= 190)
                {
                    return 820;
                }
                else if (vehicle.Co2Emissions <= 225)
                {
                    return 1230;
                }
                else if (vehicle.Co2Emissions <= 255)
                {
                    return 1750;
                }
                else
                    return 2060;
            }
            return 0;
        }
     
    }
}
