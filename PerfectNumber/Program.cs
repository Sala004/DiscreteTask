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

            for (int i = n1; i <= n2; i++)   
            {
                int sum = 0;              
                for (int j = 1; j < i; j++)        
                {
                    if (i % j == 0)                 
                        sum += j; 
                }

                if (sum == i)   
                    Console.WriteLine(i);
            }
        }
    }
}
