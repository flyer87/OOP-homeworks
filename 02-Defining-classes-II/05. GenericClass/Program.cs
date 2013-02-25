/* 
 * - Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
 * clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.

 * - Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 * Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
 * You may need to add a generic constraints for the type T.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GenericList<int> gl = new GenericList<int>(2);
        gl.Add(2);
        gl.Add(500);
        gl.Add(6);
        gl.Add(-7);
        gl.RemoveAt(2);
        gl.InsertAt(1, 5);
        gl.InsertAt(1, 6);
        gl.InsertAt(1, 7);
        gl[0] = -20000;
        //gl.Clear();
        Console.WriteLine(gl.Min<int>());
        Console.WriteLine(gl.Max<int>());
    }
}






