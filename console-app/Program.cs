using System;

namespace console_app
{
    internal class Program
    {
        public static int GetMax(int[] arr)
        {
            int max = Int32.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
        
        public static float GetAverage(int[] arr)
        {
            int suma = 0;
            foreach (int num in arr)
            {
                suma += num;
            }

            return ((float) suma )/ arr.Length;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
    }
}