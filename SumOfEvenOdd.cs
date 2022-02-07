using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Sumofevandandodds
    {
        static void Main()
        {
            sumofevenandodds();
        }
        static void sumofevenandodds()
        {
            int evenres = 0;
            int oddres = 0;
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the number{i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                {
                    evenres = j + evenres;
                }
                else
                {
                    oddres = j + oddres;
                }
            }
            Console.WriteLine($"Even result is {evenres} and {oddres}");
        }
    }
}