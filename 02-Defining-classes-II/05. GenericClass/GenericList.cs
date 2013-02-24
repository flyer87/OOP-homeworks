using System;
using System.Text;

class GenericList<T>
{
    private T[] items;
    private int currentCount = 0;

    public GenericList(int capacity)
    {
        items = new T[capacity];
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
        if (currentCount >= items.Length)
        {
            throw new IndexOutOfRangeException(String.Format("Capacity of {0} items waas exceeded!", currentCount));
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
            if (index >= items.Length - 1)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
            }

            T result = items[index];
            return result;
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
            throw new IndexOutOfRangeException("List is full!");
        }

        Array.Copy(this.items, index, this.items, index + 1, currentCount - index + 1);
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
