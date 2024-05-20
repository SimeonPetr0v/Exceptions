using System.Diagnostics;

namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + 5);
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num));
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
            Console.WriteLine("Program ended");
            }
    }
}
