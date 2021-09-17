using System;

namespace GenericsEg
{
    class Program
    {
        static void main(string[] args)
        {
            int[] numbers;
            Console.WriteLine("Enter the number of items");
            int size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];

            Console.WriteLine("Enter five numbers");
            for(int i=0; i<size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int item in numbers) {
                Console.WriteLine(item);
            }
        }
    }
}
