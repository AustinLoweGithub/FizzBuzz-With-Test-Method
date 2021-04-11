using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzzPrint
    {

        public string _FizzBuzz { get; set; }
        public int currNum { get; set; }

        public string FizzBuzzPrinter(int currNum) {

            
            switch (true)
            {

                case true when (currNum % 3 == 0) && (currNum % 5 == 0):

                    return "FizzBuzz";
                    

                case true when (currNum % 3 == 0):
                    return "Fizz";
                    

                case true when (currNum % 5 == 0):

                    return "Buzz";

                default:
                    return currNum.ToString();
                   
                    



            }
        
        
        
        
        }




    }
}
