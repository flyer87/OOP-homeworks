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
