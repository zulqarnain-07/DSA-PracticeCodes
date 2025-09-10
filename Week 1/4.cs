using System;


class Program
{
    unsafe static void Main()
    {
        char x = 'A';
        int y = 100;
        float z = 3.14f;

        // Get address of char
        char* ptrX = &x;
        Console.WriteLine($"Address of char x in RAM/Virtual Memory = {(ulong)ptrX}");
        Console.WriteLine($"Value of x = {*ptrX}");

        // Get address of int
        int* ptrY = &y;
        Console.WriteLine($"Address of int y in RAM/Virtual Memory = {(ulong)ptrY}");
        Console.WriteLine($"Value of y = {*ptrY}");

        // Get address of float
        float* ptrZ = &z;
        Console.WriteLine($"Address of float z in RAM/Virtual Memory = {(ulong)ptrZ}");
        Console.WriteLine($"Value of z = {*ptrZ}");
    }
}
