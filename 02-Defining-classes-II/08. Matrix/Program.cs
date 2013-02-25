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



    }
}
