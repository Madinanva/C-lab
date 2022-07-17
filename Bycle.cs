using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Bycle : Vehicle
    {
        public Bycle(string color, string brand, int milliage) : base(color, brand, milliage)
      {
         base.Color = color;
         base.Brand = brand;
         base.Milliage = milliage;
         milliage++;
      }
        public void Drive()
        {
            base.Milliage++;
        }
        
        public override void ShowInfo()
       {
         base.ShowInfo();
       }
     }
  }
