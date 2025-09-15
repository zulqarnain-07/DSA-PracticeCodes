//Calculation of number of moves for N number of disk in
//Tower of Hanoi problem using recursion.



using System;
using System.Security.Cryptography.X509Certificates;

class MatrixOperations
{
  
    
        public static void Main(String[] args)
    {
        int n = 4;
        towerOfHanoi(n, 'A', 'C', 'B'); 

        int totalMoves = (int)Math.Pow(2, n) - 1;
        Console.WriteLine("Total moves required: " + totalMoves + "\n");

    }


    static void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
    {

        if (n == 1)
        {
            Console.WriteLine("Move disk 1 from rod " +
            from_rod + " to rod " + to_rod);
            return;
        }
        towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
        Console.WriteLine("Move disk " + n + " from rod " +
        from_rod + " to rod " + to_rod);
        towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
    }

}