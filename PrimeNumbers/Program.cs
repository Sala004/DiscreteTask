using System.Globalization;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, num1, j;

            Console.Write("Enter Starting Number: ");    
            
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Ending Number: ");       
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrime Numbers between {0} and {1} are: ", n1, n2);

            for (num1 = n1; num1 <= n2; num1++)      
            {
                for (j = 2; j < num1; j++)                    
                {
                    if (num1 % j == 0)
                        break;
                }               
                if (j == num1)                                                   
                    Console.WriteLine(num1);
            }
        }
    }
}