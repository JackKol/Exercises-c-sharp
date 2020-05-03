using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise45
    {
        public static void Do()
        {
            int[] numbers = {1, 2, 3, 4, 5, 5, 5};
            
            Console.WriteLine("Input an integer:");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of "+ x +" present in the said array:");
            var countnumb = numbers.Count((y => y == x));

            Console.WriteLine(countnumb);
            Console.ReadKey();
        }
    }
}