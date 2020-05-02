using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise8
    {
        public static void Do()
        {
            int x;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(": {0} x {1} = {2}", x, i, (x * i));
            }
            Console.Read();
        }
    }
}
