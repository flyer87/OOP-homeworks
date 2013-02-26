/*
 * - Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
 * - Implement an indexer this[row, col] to access the inner matrix cells.
 * - Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
     Throw an exception when the operation cannot be performed. 
 * - Implement the true operator (check for non-zero elements).
 * - 
 */

using System;
using System.Collections.Generic;

class Matrix<T>
    where T : IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    private T[,] matrix;
    private readonly int maxRow;
    private readonly int maxCol;

    public Matrix(int row, int col)
    {
        if (row < 0 || col < 0)
        {
            throw new ArgumentOutOfRangeException("Row/Col should be positive integer!");
        }

        matrix = new T[row, col];
        maxRow = row;
        maxCol = col;
    }

    public T this[int row, int col]
    {
        get
        {
            if ((row < 0) || (row >= maxRow))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid row = {0}", row));
            }

            if ((col < 0) || (col >= maxCol))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid column = {0}", col));
            }

            T item = this.matrix[row, col];
            return item;
        }

        set
        {
            if ((row < 0) || (row >= maxRow))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid row = {0} !", row));
            }

            if ((col < 0) || (col >= maxCol))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid column = {0} !", col));
            }

            matrix[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if ((matrix1.maxRow != matrix2.maxRow) || matrix1.maxCol != matrix2.maxCol)
        {
            throw new ArgumentException("Huh! You cannot add! Row number AND columns number should be equal!");
        }

        Matrix<T> tempMatrix = new Matrix<T>(matrix1.maxRow, matrix1.maxCol);
        for (int row = 0; row < matrix1.maxRow; row++)
        {
            for (int col = 0; col < matrix1.maxCol; col++)
            {
                tempMatrix[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
            }
        }

        return tempMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if ((matrix1.maxRow != matrix2.maxRow) || matrix1.maxCol != matrix2.maxCol)
        {
            throw new ArgumentException("Huh! You cannot substract! Row number AND columns number should be equal!" );
        }

        Matrix<T> tempMatrix = new Matrix<T>(matrix1.maxRow, matrix1.maxCol);
        for (int row = 0; row < matrix1.maxRow; row++)
        {
            for (int col = 0; col < matrix1.maxCol; col++)
            {
                tempMatrix[row, col] = (dynamic)matrix1[row, col] - matrix2[row, col];
            }
        }

        return tempMatrix;
    }


    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if ((matrix1.maxCol != matrix2.maxRow))
        {
            throw new ArgumentException("Huh! You can not multiplicate! Number of first matrix's columns should = Number of second matrix's rows");
        }

        Matrix<T> tempMatrix = new Matrix<T>(matrix1.maxRow, matrix1.maxCol);
        for (int row = 0; row < matrix1.maxRow; row++)
        {
            // repeat matrix2.maxCol (number of second matrix's columns) times
            for (int col = 0; col < matrix2.maxCol; col++)
            {
                for (int col1 = 0; col1 < matrix1.maxCol; col1++)
                {
                    tempMatrix[row, col] += (dynamic)matrix1[row, col1] * matrix2[col1, col];
                }
            }
        }

        return tempMatrix;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.maxRow; row++)
        {
            for (int col = 0; col < matrix.maxCol; col++)
            {
                if (matrix[row, col].CompareTo(0) == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int row = 0; row < matrix.maxRow; row++)
        {
            for (int col = 0; col < matrix.maxCol; col++)
            {
                if (matrix[row, col].CompareTo(0) == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

}
