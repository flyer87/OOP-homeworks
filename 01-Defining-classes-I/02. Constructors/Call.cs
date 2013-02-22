using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Call
{
    private DateTime callDateTime;
    private string dialedNumber;
    private uint duration;

    public Call(DateTime callDateTime, string dialedNumber, uint duration)
    {
        this.callDateTime = callDateTime;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }

    public DateTime CallDateTime
    {
        get { return callDateTime; }
        set { callDateTime = value; }
    }

    public string DialedNumber
    {
        get { return dialedNumber; }
        set { dialedNumber = value; }
    }

    public uint Duration
    {
        get
        {
            return duration;
        }
        set
        {
            duration = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Dilaed number: " + this.dialedNumber);
        builder.Append(" Call time: " + this.callDateTime);
        builder.Append(" Duration: " + this.duration);
        return builder.ToString();
    }


}

