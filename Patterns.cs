using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Patterns
    {
        public static void Design()
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            Design();
        }
    }
}
