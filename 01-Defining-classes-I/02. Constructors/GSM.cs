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

    public Battery battery = new Battery("Nokia battery");
    public Display dispaly = new Display(3.4m, 35564);

    public GSM()
        : this(null, null, null, null)
    {
        // ???? Constructors 
    }

    public GSM(string model, string producer, decimal? price, string owner)
    {
        this.Model = model;
        this.Producer = producer;
        this.Price = null;
        this.Owner = owner;
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(model) || String.IsNullOrWhiteSpace(model))
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
            if (String.IsNullOrEmpty(producer) || string.IsNullOrWhiteSpace(producer))
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
            if (price == null || price > 0)
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

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("GSM:");
        builder.Append("Model - " + this.model + "; ");
        builder.Append("Producer - " + this.producer + "; ");
        builder.Append("Price - " + this.price + "; ");

        // nor full add data for Battery and Display 
        return builder.ToString();
    }

}
