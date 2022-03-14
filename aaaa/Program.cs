using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa
{
    public class Abc
    {

        public static void fizzBuzz()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc Abc = new Abc();
            Abc.fizzBuzz();

            Console.ReadKey();
        }
    }

}
