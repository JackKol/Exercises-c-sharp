using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class LoopExercise2
    {
        public static void Do()
        {
            int number;
            var total = 0;
            for (number = 1; number <= 10; number++)
            {
                total = total + number;
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
        
    }
}
        


