using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Tables
    {
        public static void multi()
        {
            int a = 1;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (a <= 10)
            {
                //Console.WriteLine(n+"*"+a+"="+(n*a));
                Console.WriteLine($"{n} * {a} ={n * a }");
                a++;
            }
        }
        static void Main(string[] args)
        {
            multi();
            
        }
    }
}
