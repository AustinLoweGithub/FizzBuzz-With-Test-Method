using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClassLibrary;

namespace FizzBuzz
{
    class program
    {
        static void Main(string[] args)
        {

            FizzBuzzPrint _writer = new FizzBuzzPrint();

            for (int i = 0; i<=100; i++)
            {
               string _current = _writer.FizzBuzzPrinter(i);

                Console.WriteLine(_current);

                    _writer.currNum += 1;



            }



            Console.ReadLine();

        }
    }
}
