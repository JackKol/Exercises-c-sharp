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
            Console.WriteLine("array =  12, 22, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 18, 18, 1");

            IEnumerable<int>[] newarray = {array.Where(x => x > 10)}; //array.Count(x => x > 10);
            


            Console.WriteLine("Array = " + newarray);
            Console.ReadKey();
        }
    }
}
