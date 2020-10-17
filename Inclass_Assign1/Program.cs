using System;

namespace Inclass_Assign1
{
           class Inclass_Assignment
        {
            static void Main()
            {

                int isum = 0, num1;
                double dsum = 0.0;
                Console.WriteLine("\nEnter Numbers Seperated by + delimiter");
                string input = Console.ReadLine();
                string[] tokens = input.Split('+');
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (int.TryParse(tokens[i], out num1))
                        isum += num1;
                    else
                        dsum += double.Parse(tokens[i]);
                }

                Console.WriteLine("\n\n\tSum of integer values " + isum);
                Console.WriteLine("\n\n\tSum of decimal values " + dsum);
                Console.WriteLine("\n\n\tSum of all input " + (isum + dsum));
            }
        }
    }


