using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise49
    {
        public static void Do()
        {
            int[] Array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] Array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            Console.WriteLine("Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]");
            Console.WriteLine("Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]");

            if ((Array1.First() == Array2.First() && Array1.Length >= 1) ||
                ((Array1.Last() == Array2.Last() && Array1.Length >= 1))) 
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadKey();
        }
    }
}
