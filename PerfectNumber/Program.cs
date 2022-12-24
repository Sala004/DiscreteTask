namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Starting Number: ");      

            int n1 = int.Parse(Console.ReadLine());          

            Console.Write("Enter the End Number: ");    

            int n2 = int.Parse(Console.ReadLine());           

            Console.WriteLine("Perfect Numbers Between {0} and {1} are: ", n1, n2);

            for (int num1 = n1; num1 <= n2; num1++)   
            {
                int sum = 0;              
                for (int j = 1; j < num1; j++)        
                {
                    if (num1 % j == 0)                 
                        sum += j; 
                }

                if (sum == num1)   
                    Console.WriteLine(num1);
            }
        }
    }
}
