using System;

namespace Inclass_Assign1
{
    class Inclass_Assignment
    {

        static void Main()
        {

            int isum = 0, num1;
            double dsum = 0.0, num2;
            Console.WriteLine("\nEnter Numbers Seperated by + delimiter");
            string input = Console.ReadLine();
            string[] tokens = input.Split('+');
            try
            {

                foreach (string x in tokens)

                    if (int.TryParse(x, out num1))
                        isum += num1;
                    else if (double.TryParse(x, out num2))
                        dsum += num2;
                    else
                        throw new FormatException();


                Console.WriteLine("\n\n\tSum of integer values " + isum);
                Console.WriteLine("\n\n\tSum of decimal values " + Math.Round(dsum, 2));
                Console.WriteLine("\n\n\tSum of all input " + Math.Round(isum + dsum, 2));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Avoid alphabets and special characters");
            }

        }
    }
