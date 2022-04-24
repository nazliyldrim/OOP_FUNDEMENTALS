using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Class
{
    public class Iron
    {
        
        //Let us consider properties of an ironing object.There are brand,color,temperature,boiler...
        //PROPERTİES:
        public string Brand { get; set; } 
        public string Color { get; set; }
        public bool IsBoiler { get; set; }
        public int Temperature { get; set; }
        //CONSTRUCTOR METHOD:
        public Iron()
        {
            Console.WriteLine("The ironing object has been created...");
        }
        //CONSTRUCTOR METHOD WITH PARAMETERS:
        public Iron(string brand,string color,bool isBoiler,int temperature)
        {
            this.Brand = brand;
            this.Color = color;
            this.IsBoiler = isBoiler;
            this.Temperature = temperature;
            Console.WriteLine($"The ironing object has been created with this informations:\nBrand:{brand}\nColor:{color}\nTemperature:{temperature}\nIs boiler:{(isBoiler ? "Yes" : "No")}");
        }
    }
}
