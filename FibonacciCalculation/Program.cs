namespace FibonacciCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of terms");
            int n = int.Parse(Console.ReadLine());
            DateTime start = DateTime.Now;
            Console.WriteLine($"Term {n} = {fibonacci(n-1)}");
            DateTime end = DateTime.Now;
            TimeSpan processTime = end.Subtract(start);
            Console.WriteLine($"Process took {processTime.TotalMilliseconds} milliseconds");
            Console.WriteLine($"or {processTime.TotalSeconds} seconds");
        }
        static long fibonacci (int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return fibonacci(n - 1) + fibonacci(n -2);
        }
    }
}
