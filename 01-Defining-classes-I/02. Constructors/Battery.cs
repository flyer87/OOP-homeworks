using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BatteryType { LiIon, NiMH, NiCd };

public class Battery
{
    private string batteryModel;
    private int? hoursTalk;
    private int? idleTime;
    private BatteryType? batteryType;


    public Battery(string batteryModel)
        : this(batteryModel, null, null, null)
    {
    }

    public Battery(string batteryModel, int? hoursTalk)
        : this(batteryModel, hoursTalk, null, null)
    {
    }

    public Battery(string batteryModel, int? hoursTalk, int? idleTime)
        : this(batteryModel, hoursTalk, idleTime, null)
    {
    }

    public Battery(string batteryModel, int? hoursTalk, int? idleTime, BatteryType? batteryType)
    {
        this.HoursTalk = hoursTalk;
        this.IdleTime = idleTime;
        this.BatteryModel = batteryModel;
        this.BatteryTypeProp = batteryType;
    }

    public string BatteryModel
    {
        get { return batteryModel; }
        set { batteryModel = value; }
    }

    public int? IdleTime
    {
        get { return idleTime; }
        set
        {
            if (value == null || (value > 0 && value <= int.MaxValue))
            {
                idleTime = value;
            }
            else
            {
                throw new ArgumentException("Invalid idle time!");
            }
        }
    }

    public int? HoursTalk
    {
        get { return hoursTalk; }
        set
        {
            if (value == null || (value > 0 && value < 10))
            {
                hoursTalk = value;
            }
            else
            {
                throw new ArgumentException("invlaid hours!");
            }
        }
    }

    public BatteryType? BatteryTypeProp
    {
        get { return batteryType; }
        set
        {
            BatteryType bt;
            if (value == null || value != null) // ??? dali batteryType e w BatteryType
            {
                batteryType = value;
            }

        }
    }


}

