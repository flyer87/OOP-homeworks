/*
 * - Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
 * - Implement an indexer this[row, col] to access the inner matrix cells.
 * - Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
     Throw an exception when the operation cannot be performed. 
 * - Implement the true operator (check for non-zero elements).
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Matrix<int> m1 = new Matrix<int>(2, 3);
        m1[0, 0] = 3;
        m1[0, 1] = 3;
        m1[0, 2] = 3;
        m1[1, 0] = 2;
        m1[1, 1] = 2;
        m1[1, 2] = 2;

        Matrix<int> m2 = new Matrix<int>(2, 3);
        m2[0, 0] = 1;
        m2[0, 1] = 1;
        m2[0, 2] = 1;
        m2[1, 0] = 0;
        m2[1, 1] = 0;
        m2[1, 2] = 0;

        Matrix<int> m3 = new Matrix<int>(2, 3);
        m3 = m1 + m2;

        m3 = m1 - m2;

        if (m1)
        {
            Console.WriteLine("Matrix m1 has NOT zero elements!");
        }
        else
        {
            Console.WriteLine("Matrix m1 HAS not zero elements!");
        }

        if (m2)
        {
            Console.WriteLine("Matrix m2 has NOT zero elements!");            
        }
        else
        {
            Console.WriteLine("Matrix m2 HAS zero elements!");            
        }
    }
}
