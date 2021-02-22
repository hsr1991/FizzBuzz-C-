using System;
using System.Collections.Generic;

namespace FizzbuzzC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                List<String> output = new List<String> { };
                if (i % 3 == 0)
                {
                    output.Add("Fizz");
                }
                if (i%13 == 0) {
                    output.Add("Fezz");
                }
                if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }
                  if (i%7 == 0)
                {
                    output.Add("Bang");
                }
                  if (i%11 == 0) 
                  {
                      List<String> output2 = new List<String> { "Bong"};
                      Console.WriteLine(String.Join("", output2));
                      
                  }
                  if (i%11 == 0 && i%13 == 0) {
                    List<String> output3 = new List<String> { "FezzBong"};
                      Console.WriteLine(String.Join("", output3));
                  }
                {
                        if (i%17 == 0) {
                      output.Reverse();
                  }

                }
                if (output.Count == 0)
                {
                    Console.WriteLine(i);
                }
              
                else
                {
                    Console.WriteLine(String.Join("", output));
                    
                }





            }


        }
    }
}
