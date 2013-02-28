using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class ExtendStringBuilder
{
    public static StringBuilder Substring(this StringBuilder builder, int index, int length)
    {
        return new StringBuilder(builder.ToString(index, length));
    }
}
