using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Car
    {
        public string carMake { get; set; }
        public string mfgYear { get; set; }
        public string carModel { get; set; }
        public string city { get; set; }

        public Car(string make, string year, string model, string city)
        {
            carMake = make;
            mfgYear = year;
            carModel = model;
            this.city = city;
        }

        public void DisplayCar()
        {
            Console.WriteLine(carMake);
            Console.WriteLine(mfgYear);
            Console.WriteLine(carModel);
            Console.WriteLine(city);
        }
    }
}
