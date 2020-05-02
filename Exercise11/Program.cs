using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than {0} ", age);
            Console.Read();
        }
    }
}
