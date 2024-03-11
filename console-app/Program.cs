using System;

namespace console_app
{
    internal class Program
    {
        public static float GetAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            return ((float) sum )/ arr.Length;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
    }
}