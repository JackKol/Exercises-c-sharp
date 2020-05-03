using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ExerciseFromTaras
    {
        public static void Do()
        {
            int[] array = { 12, 22, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 18, 18, 1 };

            List<int> newArray = FilterArray(array, 10);

            Console.WriteLine("Array = " + string.Join(",", newArray));
            Console.ReadKey();
        }

        private static List<int> FilterArray(int[] array, int filterValue)
        {
            var newArray = array.Where(x => x > filterValue).ToList();
            return newArray;
        }
    }
}
