using System;

namespace Exercise1
{
    class Exercise36
    {
        public static void Do()
        {
            Console.WriteLine("Input a first number:");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a second number:");
            var y = Convert.ToInt32(Console.ReadLine());

            if ((x >= -10) && (y >= -10) && ((x <= 10) && (y <= 10)))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
