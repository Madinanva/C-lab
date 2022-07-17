using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Milliage { get; set; } 
        public Vehicle(string color, string brand, int milliage) 
        {
            Color = color;
            Brand = brand;
            Milliage = milliage++;
        }
        public void Drive()
        {
            Milliage++;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Color},{Brand},{Milliage}"); 
        }
    }
}
