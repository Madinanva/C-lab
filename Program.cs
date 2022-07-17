using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car(60,92,14,"White", "Porsche", 12);
            Vehicle vehicle2 = new Car(70,95,14,"Black", "Bmw", 13);
            Vehicle vehicle3 = new Bycle("Yellow","Bycle", 3);
            vehicle1.Drive();
            vehicle2.Drive();
            vehicle3.Drive();
            vehicle1.ShowInfo();
            vehicle2.ShowInfo();
            vehicle3.ShowInfo();

        }
    }
}