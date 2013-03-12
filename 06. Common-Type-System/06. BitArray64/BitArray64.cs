using System;
using System.Collections.Generic;

class BitArray64 : IEnumerable<int>
{
    private ulong number;

    // constructor
    public BitArray64(ulong ulongNumber)
    {
        this.number = ulongNumber;
    }

    #region Methdos
    // implement GetEnumerator() - I
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 63; i++)
        {
            yield return (int)((this.number >> i) & 1);
        }
    }

    // implement GetEnumerator() - II
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    // override GetHashCode()
    public override int GetHashCode()
    {
        int temp = 5;
        return temp *= number.GetHashCode() ^ 27;
    }

    // override Equals
    public override bool Equals(object param)
    {
        if (param == null)
        {
            return false;
        }

        BitArray64 bitarray = param as BitArray64;
        if (this.number != bitarray.number)
        {
            return false;
        }

        return true;
    }

    //predefine opearotor ==
    public static bool operator ==(BitArray64 bitarray1, BitArray64 bitarray2)
    {
        return bitarray1.Equals(bitarray2);
    }

    //predefine opearotor !=
    public static bool operator !=(BitArray64 bitarray1, BitArray64 bitarray2)
    {
        return !bitarray1.Equals(bitarray2);
    }

    // predefine []
    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new ArgumentOutOfRangeException("index must be [0,63]");
            }

            return (int)((number >> index) & 1);
        }

        set
        {
            if (index < 0 || index > 63)
            {
                throw new ArgumentOutOfRangeException("index must be [0,63]");
            }

            if (value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException("value must be 0 or 1");
            }

            number &= ~(ulong)(1 << index);
            number |= ~(ulong)(value << index);
        }

    }

    #endregion


}