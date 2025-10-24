//Q5.Create a Car class with a property Speed.
//• Speed should not exceed 180 km/h; if it exceeds, reset to 180.
//• Write code to set speed = 150, then 200, and display the final speed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 180)
                {
                    speed = 180;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
    internal class Program5
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 150;
            Console.WriteLine($"Car Speed (set to 150): {car.Speed} km/h");
            car.Speed = 200;
            Console.WriteLine($"Car Speed (set to 200): {car.Speed} km/h");
            Console.ReadLine();
        }
    }
}