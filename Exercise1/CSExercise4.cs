using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CSExercise4
    {
        public static void Do()
        {
            int year = 0;

            while (year < 100 || year >= 10000) //трех- или четырехзначноe положительноe числo
            {
                Console.WriteLine("Input the year ");
                year = Convert.ToInt32(Console.ReadLine());
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) //если делится на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
            {
                Console.WriteLine(year.ToString() + " is a leap year");
            }
            else
            {
                Console.WriteLine(year.ToString() + "is a not leap year");
                Console.ReadKey();
            }
        }
    }
}
