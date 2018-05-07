using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 17;
            
            Console.WriteLine("Welcome to the Factorial Calculator!");
            while (true)
            { 
            Console.WriteLine("Please enter an integer from 1 to 17: ");
            n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of {n} is {factorial}.");
                {

                    do
                    {
                        factorial *= n;
                        n--;
                    } while (n > 0);

                    Console.WriteLine("n! = {0}", factorial);
                    
                    {
                        string response;
                        Console.WriteLine("Would you like to enter another number? (Y/N)?");
                        response = Console.ReadLine();

                        if (response.ToUpper() == "N")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }
                        else if (response.ToUpper() == "Y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("The number you entered is invalid.");
                        }
                                                
                    }
                }
            }    
        }
   
    }
}
