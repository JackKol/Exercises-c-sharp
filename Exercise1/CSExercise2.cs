using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CSExercise2
    {
        public static void Do()
        {
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 > 0)
                Console.WriteLine(+ x + "is an odd integer");
            else
                Console.WriteLine(+ x + "is an even integer");
            Console.ReadKey();
        }
    }
}
