using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class LoopExercise10
    {
        public static void Do()
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= x; y++)
                    Console.Write("{0}", y);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
