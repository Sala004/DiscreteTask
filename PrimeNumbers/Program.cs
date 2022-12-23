using System.Globalization;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j;

            Console.Write("Enter Starting Number: ");    
            
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Ending Number: ");       
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrime Numbers between {0} and {1} are: ", n1, n2);

            for (i = n1; i <= n2; i++)      
            {
                for (j = 2; j <= i; j++)                    
                {
                    if (i % j == 0)
                        break;
                }               
                if (j == i)                                                   
                    Console.WriteLine(i);
            }
        }
    }
}