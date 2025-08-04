using System;
using System.Linq;
using System.Threading;


namespace Serhun_13_1_HW6
{
    internal class Program
    {
        static void vivodRazdeliteley(string razdelitel)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat(razdelitel, 40)));
        }
        static int[][] matrixAllMemory(int lengthX, int lengthY)
        {
            int[][] matrix = new int[lengthX][];
            for (int i = 0; i < lengthX; i++)
            {
                matrix[i] = new int[lengthY];
            }
            return matrix;
        }
        static int[][] createSqrMatrix(int length, int min, int max)
        {
            return createMatrix(length, length, min, max);
        }
        static int[][] createMatrix(int lengthX, int lengthY, int min, int max)
        {
            int[][] matrix = matrixAllMemory(lengthX, lengthY);
            Random random = new Random();
            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    matrix[i][j] = random.Next(min, max + 1);
                }
            }
            return matrix;
        }
        static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Task 1
            
            {
                int[][] matrix = createSqrMatrix(10, 1, 100);
                printMatrix(matrix);
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] % 10 == 0)
                        {
                            matrix[i][j] = 404;
                        }
                    }
                }
                vivodRazdeliteley("-");
                printMatrix(matrix);
            }
            
            //Task 2
            /*
            {
                int[][] matrix = createSqrMatrix(10, 1, 99);
                printMatrix(matrix);
                int sum = 0;
                vivodRazdeliteley("-");
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] % 2 == 0 && matrix[i][j] > 50 && matrix[i][j] < 90 && matrix[i][j] % 10 != 0)
                        {
                            sum += matrix[i][j];
                        }
                    }
                }
                Console.WriteLine("Sum of even numbers between 50 and 90 (not including multiples of 10): " + sum);
            }
            */
            //Task 3
            /*
            {
                int[][] matrix = matrixAllMemory(10, 10);
                int[] num = { 2, 5, 9 };
                int count = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = num[count%3];
                        count++;
                    }
                }
                printMatrix(matrix);
            }
            */
            //Task 4 original
            /* Написати програму в якій ви створите двовимірний масив розміром 4 на 4.
            Заповнити його випадковими числами таким чином щоб у кожному рядку і 
            стовпчику сума елементів дорівнювала числу 100.Вивести масив на екран. 
            */
            /*
            {
                int size = 4, sumX = 0;
                int[] sumY = new int[size];
                int[][] matrix = matrixAllMemory(size,size);
                Random random = new Random();
                while (true)
                {
                    for (int i = 0; i < size; i++)
                    {
                        sumX = 0;
                        while (sumX != 100)
                        {
                            sumX = 0;
                            for (int j = 0; j < size; j++)
                            {
                                matrix[i][j] = random.Next(0, 50);
                                sumX += matrix[i][j];
                            }
                        }
                    }
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            sumY[i] += matrix[j][i];
                        }
                        if (sumY[i] != 100)
                        {
                            sumY[i] = 0;
                            break;
                        }
                    }
                    int sum = 0;
                    for (int i = 0; i < size; i++)
                    {
                        sum += sumY[i];
                    }
                    if (sum == 400)
                        break;
                }
                printMatrix(matrix);
            }
            */
            //Task 4 changed
            /*
            try
            {
                Console.WriteLine("Enter the size of the matrix (N x N): ");
                int size = Convert.ToInt32(Console.ReadLine());
                if (size <= 0)
                {
                    throw new Exception("Size must be a positive");
                }
                int[][] matrix = matrixAllMemory(size, size);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j != 0 && j != size-1 && i != 0 && i != size-1)
                        {
                            matrix[i][j] = 2;
                        }
                        else if((j == 0 || j == size - 1) && (i == 0 || i == size-1))
                        {
                            matrix[i][j] = 8;
                        }
                        else
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
                printMatrix(matrix);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
        }
    }
}
