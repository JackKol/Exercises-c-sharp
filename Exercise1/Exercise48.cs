using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise48
    {
        public static void Do()
        {
            int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

            Console.WriteLine("Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]");
            
            if ((array.First() == array.Last()) && (array.Length >= 1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
