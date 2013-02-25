/* 
 * Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
 * clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.

 * Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 * Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
 * You may need to add a generic constraints for the type T.
 */

using System;
using System.Text;

class GenericList<T>
{
    private T[] items;
    private int currentCount = 0;
    private int size;

    public GenericList(int capacity)
    {
        items = new T[capacity];
        size = capacity;
    }

    public int Count
    {
        get
        {
            return currentCount;
        }
    }

    public void Add(T item)
    {
        if (currentCount == items.Length)
        {
            if (currentCount == this.items.Length)
            {
                Array.Resize<T>(ref items, size * 2);
                size *= 2;            
            }            
        }
        else
        {
            this.items[currentCount] = item;
            currentCount++;
        }
    }

    // GenericList<T> myList = new GenericList<int>();
    // myList[5] <-- тук се реализира именно тази функционалност !!!
    public T this[int index]
    {
        get
        {
            if ((index >= items.Length - 1) || (index < 0))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }

            T result = items[index];
            return result;
        }
        set
        {
            if ((index >= items.Length - 1) || (index < 0))
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }

            items[index] = value;
        }
    }

    public void RemoveAt(int index)
    {
        if ((index < 0) || (index >= items.Length))
        {
            throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
        }

        Array.Copy(this.items, index + 1, this.items, index, currentCount - index);
        currentCount--;
    }

    public void InsertAt(int index, T value)
    {
        if (currentCount >= this.items.Length)
        {
            Array.Resize<T>(ref this.items, size * 2);
            size *= 2;
            // throw new IndexOutOfRangeException("List is full!");
        }

        Array.Copy(this.items, index, this.items, index + 1, currentCount - index);
        this.items[index] = value;
        currentCount++;
    }

    public void Clear()
    {
        if (currentCount > 0)
        {
            Array.Clear(this.items, 0, currentCount);
            currentCount = 0;
        }
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(this.items, item);
    }

    public T Min<T>() where T : IComparable<T>
    {
        dynamic minItem = this.items[0];
        for (int i = 1; i < currentCount; i++)
        {
            if (minItem.CompareTo(this.items[i]) > 0)
            {
                minItem = this.items[i];
            }
        }

        return (T)minItem;
    }

    public T Max<T>() where T : IComparable<T>
    {
        dynamic maxItem = this.items[0];
        for (int i = 1; i < currentCount; i++)
        {
            if (maxItem.CompareTo(this.items[i]) < 0)
            {
                maxItem = this.items[i];
            }
        }

        return (T)maxItem;
    }


    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < currentCount; i++)
        {
            builder.Append(this.items[i] + ", ");
        }

        builder.Remove(builder.Length - 2, 2);
        return builder.ToString();
    }
}
