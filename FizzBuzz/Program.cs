using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index <= 100; index++)
            {
                if (index % 3 == 0 && index % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                else if
                    (index % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                else if
                    (index % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else
                {   
                    WriteLine(index);
                }
                    ReadKey();
              }
                
          }
    }
}
