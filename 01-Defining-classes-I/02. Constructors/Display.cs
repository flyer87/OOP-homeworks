﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Display
{
    private decimal? size;
    private int? colors;

    public Display()
        : this(null, null)
    {
    }

    public Display(int? colors)
        : this(null, colors)
    {
    }

    public Display(decimal? size)
        : this(size, null)
    {
    }

    public Display(decimal? size, int? colors)
    {
        this.size = size;
        this.colors = colors;
    }

    public decimal? Size
    {
        get { return size; }
        set
        {
            if ((value != null) && ((value < 0) || (value > Decimal.MaxValue)))
            {
                throw new ArgumentException("Invadid size!");
            }
            size = value;
        }
    }

    public int? Colors
    {
        get { return colors; }
        set
        {
            if ((value == null) || ((value > 0) && (value <= int.MaxValue)))
            {
                colors = value;
            }
            else
            {
                throw new ArgumentException("Invalid size!");
            }

        }
    }
    
}
