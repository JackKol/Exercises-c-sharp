using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise6
    {
        public static void Do()
        {
            int firstnumber;
            Console.WriteLine("Input the first number to multiply");
            firstnumber = Convert.ToInt32(Console.ReadLine());


            int secondnumber;
            Console.WriteLine("Input the second number to multiply");
            secondnumber = Convert.ToInt32(Console.ReadLine());

            int thirdnumber;
            Console.WriteLine("Input the third number to multiply");
            thirdnumber = Convert.ToInt32(Console.ReadLine());

            int ExpectedOutput = firstnumber * secondnumber * thirdnumber;


            Console.WriteLine("{0}*{1}*{2}={3}", firstnumber, secondnumber, thirdnumber, ExpectedOutput);

            Console.Read();
        }
    }
}