using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise1
{
    class Exercise39
    {
        public static void Do()
        {
            Console.WriteLine("Input first integer:");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer:");
            var y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input third integer:");
            var z = Convert.ToInt32(Console.ReadLine());

            int[] numbers = {x,y,z};

            int maxoFnumbers = numbers.Max();
            int minoFnumbers = numbers.Min();

            Console.WriteLine("Largest of three: " + maxoFnumbers);
            Console.WriteLine("Lowest of three: " + minoFnumbers);
  
            Console.ReadKey();
        }
    }
}
