// 1.Write a c# program which input 2 matrix of user defined rows and columns and perform following
// operation  a. Display/Print as a Matrix b. Addition of Matrix c. Subtraction of Matrix d. matrix multiplication
// e. Determinant f. Inverse

using System;

class MatrixOperations
{
    static void Main()
    {
        Console.Write("Enter number of rows for matrices: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns for matrices: ");
        int cols = int.Parse(Console.ReadLine());

        double[,] A = new double[rows, cols];
        double[,] B = new double[rows, cols];

        Console.WriteLine("\nEnter elements of Matrix A:");
        InputMatrix(A);

        Console.WriteLine("\nEnter elements of Matrix B:");
        InputMatrix(B);

        Console.WriteLine("\nMatrix A:");
        PrintMatrix(A);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(B);

        Console.WriteLine("\nMatrix Addition:");
        PrintMatrix(AddMatrices(A, B));

        Console.WriteLine("\nMatrix Subtraction:");
        PrintMatrix(SubtractMatrices(A, B));

        Console.WriteLine("\nMatrix Multiplication:");
        if (rows == cols) // only works if square
            PrintMatrix(MultiplyMatrices(A, B));
        else
            Console.WriteLine("Multiplication not possible! Rows must match columns.");

        if (rows == cols)
        {
            Console.WriteLine("\nDeterminant of Matrix A: " + Determinant(A));
            Console.WriteLine("\nDeterminant of Matrix B: " + Determinant(B));

            Console.WriteLine("\nInverse of Matrix A:");
            PrintMatrix(Inverse(A));

            Console.WriteLine("\nInverse of Matrix B:");
            PrintMatrix(Inverse(B));
        }
        else
        {
            Console.WriteLine("\nDeterminant and Inverse only possible for square matrices!");
        }
    }

    // Function to input matrix
    static void InputMatrix(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"Element [{i + 1},{j + 1}]: ");
                mat[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    // Function to print matrix
    static void PrintMatrix(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
                Console.Write(mat[i, j] + "\t");
            Console.WriteLine();
        }
    }

    // Matrix Addition
    static double[,] AddMatrices(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] + B[i, j];

        return result;
    }

    // Matrix Subtraction
    static double[,] SubtractMatrices(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] - B[i, j];

        return result;
    }

    // Matrix Multiplication
    static double[,] MultiplyMatrices(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = B.GetLength(1);
        int common = A.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                for (int k = 0; k < common; k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }

    // Determinant (Recursive)
    static double Determinant(double[,] mat)
    {
        int n = mat.GetLength(0);
        if (n == 1) return mat[0, 0];
        if (n == 2) return mat[0, 0] * mat[1, 1] - mat[0, 1] * mat[1, 0];

        double det = 0;
        for (int j = 0; j < n; j++)
        {
            det += Math.Pow(-1, j) * mat[0, j] * Determinant(Minor(mat, 0, j));
        }
        return det;
    }

    // Minor matrix (for determinant)
    static double[,] Minor(double[,] mat, int row, int col)
    {
        int n = mat.GetLength(0);
        double[,] minor = new double[n - 1, n - 1];
        int r = 0, c;

        for (int i = 0; i < n; i++)
        {
            if (i == row) continue;
            c = 0;
            for (int j = 0; j < n; j++)
            {
                if (j == col) continue;
                minor[r, c] = mat[i, j];
                c++;
            }
            r++;
        }
        return minor;
    }

    // Inverse of a matrix
    static double[,] Inverse(double[,] mat)
    {
        int n = mat.GetLength(0);
        double det = Determinant(mat);
        if (det == 0)
        {
            Console.WriteLine("Matrix has no inverse (det = 0)");
            return new double[n, n];
        }

        double[,] adj = Adjoint(mat);
        double[,] inv = new double[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                inv[i, j] = adj[i, j] / det;

        return inv;
    }

    // Adjoint of matrix
    static double[,] Adjoint(double[,] mat)
    {
        int n = mat.GetLength(0);
        double[,] adj = new double[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                adj[j, i] = Math.Pow(-1, i + j) * Determinant(Minor(mat, i, j));

        return adj;
    }
}
