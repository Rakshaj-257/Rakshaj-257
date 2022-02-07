using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class RealNumbers
    {
        public static void logics()
        {
            int PSum = 0;
            int NSum = 0;
            int PCount = 0;
            int NCount = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter The Numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    PCount += 1;
                    PSum += n;
                }
                else
                {
                    NCount += 1;
                    NSum += n;
                }
            }
            try
            {
                Console.WriteLine($"The Average of the Positive numbers is: {PSum / PCount} and Average of Negative Numbers is: {NSum / NCount}");
            }
            catch (Exception)
            {

                throw new Exception("Please add Some Negative values to Process");
            }
        }
        static void Main(string[] args)
        {
            logics();
        }
        
    }
}
