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
            var inputValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of "+ inputValue +" present in the said array:");
            var countNumb = numbers.Count((y => y == inputValue));

            Console.WriteLine(countNumb);
            Console.ReadKey();
        }
    }
}