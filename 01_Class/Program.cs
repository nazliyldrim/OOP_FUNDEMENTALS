using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *A class is our prototype.The class contains the basic properties for creating objects.
             * We can say that the class is define how to construct objects.
             * Constructor method is the first method to be triggered when an instance is taken from an object.A short way to create constructor method is that you should write 'ctor' and press tab key twice.This method can be empty or with parameters.
             * If only the constructor method with parameter is defined,we will have to write the parameter as importing the instance in program.cs.However,if added an empty constuctor, the problem disappears.
                        
             */


            //If i use constructor method with parameters:
            Iron iron = new Iron("Simbo","Gri",true,50);
            Console.WriteLine(new string('*',30));
            //If i dont use constructor method with parameters,i must define properties of iron.On the other hand we can't call what that we define the properties.
            Iron iron1 = new Iron();//we create ironing object.
            iron1.Brand = "Tefal";//we enter properties of our object.
            iron1.Color = "Purple";
            iron1.IsBoiler = false;
            iron1.Temperature = 90;
            Console.WriteLine($"The ironing object has been created with this informations:\nBrand:{iron1.Brand}\nColor:{iron1.Color}\nTemperature:{iron1.Temperature}\nIs boiler:{(iron1.IsBoiler ? "Yes" : "No")}"); //

            Console.ReadLine();
        }
    }
}
