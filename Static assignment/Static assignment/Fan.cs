using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_assignment
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "RED";
        
        public Fan() { }

        public int SPEED {
            get { return this.speed; }
            set {
             if(value==SLOW || value==FAST || value== MEDIUM)
                {
                    this.speed = value;
                }
              }
            }

        public bool ON
        {
            get { return this.on; } set { this.on = value; }
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value>0)
                {
                    this.radius = value;
                }
            }
        }

        public string Color
        {
            get { return this.color; } set { this.color = value; }
        }

        public new void ToString()
        {
            Console.WriteLine("Speed: "+ speed);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Fan is: " + on);
        } 
    }
}
