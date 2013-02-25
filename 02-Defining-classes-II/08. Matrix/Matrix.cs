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
            throw new ArgumentException("Huh! Ne moje da sabirash!");
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

    public static Matrix<T> operator -(Matrix<T>matrix1, Matrix<T> matrix2)
    {
        if ((matrix1.maxRow != matrix2.maxRow) || matrix1.maxCol != matrix2.maxCol)
        {
            throw new ArgumentException("Huh! Ne moje da izwajdash!");
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
            throw new ArgumentException("Huh! Ne moje da umnojawash!");
        }

        Matrix<T> tempMatrix = new Matrix<T>(matrix1.maxRow, matrix1.maxCol);
        for (int row = 0; row < matrix1.maxRow; row++)
        {


            // https://github.com/Bvaptsarov/Homework/blob/master/10.OOPSecondPart/GenericMatrix/Matrix.cs
            // https://github.com/ivivanov/TelerikAcademy/blob/master/OOP/3DPoint%2C%20GenericList%2C%20GenericMatrix/Matrix/Matrix.cs
        }

        return tempMatrix;
    }
}
