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
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            if ((array1.Length >= 1) &&
                ((array1.First() == array2.First()) ||
                 (array1.Last()  == array2.Last())))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadKey();
        }
    }
}
