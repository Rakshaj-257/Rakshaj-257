using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Conversion
    {
        static void convertMethod()
        {
            Console.WriteLine("Enter the Degree Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine(fahrenheit);
            Console.WriteLine(kelvin);
        }
        static void Main(string[] args)
        {
            convertMethod();
        }
    }
}
