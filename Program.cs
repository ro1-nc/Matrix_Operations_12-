using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3] { { 1, 5, 6 }, { 4, 8, 6 }, { 4, 1, 4 } };


            int n = 3;

            Console.WriteLine("Enter elements of 3x3 1st Matrix");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    // Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter elements of 3x3 2nd Matrix");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    // Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Matrix 1 is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix 2 is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Matrix Addition is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr1[i, j] + arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix Subtraction is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr1[i, j] - arr2[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Matrix Multplication is");

            int[,] mult_mat = new int[3, 3];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    mult_mat[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        mult_mat[i, j]+= arr1[i, k] * arr2[k, j];
                    }
                    Console.Write(mult_mat[i,j]+" ");
                }
                Console.WriteLine();
            }
            
            sd

            Console.WriteLine("Transpose of Matrix 1 is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr1[j, i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpose of Matrix 2 is");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[j, i] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
