using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CSExercise13
    {
        public static void Do()
        {
            Console.WriteLine("Input current temperature");
            var t = Convert.ToInt32(Console.ReadLine());
            if(t < 0)
                Console.WriteLine("Freezing weather");
            else if (t <= 10)
                Console.WriteLine("Very Cold weather");
            else if (t <= 20)
                Console.WriteLine("Cold weather");
            else if(t <= 30)
                Console.WriteLine("Normal in Temp");
            else if(t <= 40)
                Console.WriteLine("Its Hot"); 
            else if(t > 40)
                Console.WriteLine("Its Very Hot");
            Console.ReadKey();
        }
    }
}
//Temp< 0 then Freezing weather
//Temp 0-10 then Very Cold weather
//Temp 11-20 then Cold weather
//Temp 21-30 then Normal in Temp
//Temp 31-40 then Its Hot
//Temp >=41 then Its Very Hot