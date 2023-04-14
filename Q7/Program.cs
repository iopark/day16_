using System.Runtime.InteropServices;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[25];
            test = Generate(); 
            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}