using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
      class Car : Vehicle
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelFor1km { get; set; }
        public Car(int fuelCapacity, int currentFuel, int fuelFor1km, string color, string brand, int milliage) : base(color, brand, milliage)
        
        {
             FuelCapacity = fuelCapacity;
             CurrentFuel = currentFuel;
             FuelFor1km = fuelFor1km;
            base.Color = color;
            base.Brand = brand;
            base.Milliage = milliage;
        }
            public void Drive() 
        {
            base.Milliage++;
        }
            public override void ShowInfo()
        {
             base.ShowInfo();
            Console.WriteLine($"{FuelCapacity},{CurrentFuel},{FuelFor1km}");
        }
        public static bool CheckCarCanGo(int liter,int milliage)
        {
            if(liter > 0)
            {
                return true;
                liter--;
                milliage++;
            }
            else
            {
                return false;
                
            }
        }
    }
        
}
