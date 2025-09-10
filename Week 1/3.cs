using System;


class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };

        unsafe
        {
            fixed (int* ptr = numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Address in RAM/Virtual Memory of numbers[{i}] = {(ulong)(ptr + i)}");
                    Console.WriteLine($"Value at numbers[{i}] = {*(ptr + i)}");
                }
            }
        }
    }
}
