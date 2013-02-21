using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GSM
{
    private string model;
    private string producer;
    private decimal? price;
    private string owner;

    // static property
    private static string iPhone4S = "iPhone 4S";

    public Battery battery = new Battery("Nokia battery");
    public Display dispaly = new Display(3.4m, 35564);

    // call history object
    public List<Call> callHistory = new List<Call>();


    public GSM()
        : this(null, null, null, null)
    {
        // ???? Constructors 
    }

    public GSM(string model, string producer, decimal? price, string owner)
    {
        this.Model = model;
        this.Producer = producer;
        this.Price = price;
        this.Owner = owner;
    }

    public List<Call> CallHistory
    {
        get;
        set;
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid model name!");
            }
            model = value;
        }
    }

    public string Producer
    {
        get { return producer; }
        set
        {
            if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid Manufacturer!");
            }
            producer = value;
        }
    }

    public decimal? Price
    {
        get { return price; }
        set
        {
            if (value == null || value > 0)
            {
                price = value;
            }
            else
            {
                throw new ArgumentException("Invalid price!");
            }
        }
    }


    public string Owner
    {
        get { return owner; }
        set
        {
            owner = value;
        }
    }

    public static string IPhone4S
    {
        get
        {
            return iPhone4S;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("GSM:");
        builder.Append("Model - " + this.Model + "; ");
        builder.Append("Producer - " + this.Producer + "; ");
        builder.Append("Price - " + this.Price + "; ");
        builder.Append("Owner - " + this.Owner);

        // nor full add data for Battery and Display 
        return builder.ToString();
    }

    public void AddCall(DateTime callDateTime, string dialedNumber, uint duration)
    {
        Call call = new Call(callDateTime, dialedNumber, duration);
        this.callHistory.Add(call);
    }

    public void DeleteCalling(uint duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
            }
        }
    }

    public void ClearCallHistory()
    {
        callHistory.Clear();
    }

    public decimal CalcTotalPrice(decimal price)
    {
        decimal totalMinutes = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            totalMinutes += callHistory[i].Duration / 60;
            if (callHistory[i].Duration % 60 > 0)
            {
                totalMinutes++;
            }
        }
        return (decimal)totalMinutes * price;
    }

}
