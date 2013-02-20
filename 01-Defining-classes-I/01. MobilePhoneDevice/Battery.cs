using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battery
{
    private int hoursTalk;
    private int idleTime;
    private string batteryModel;


    public string BatteryModel
    {
        get { return batteryModel; }
        set { batteryModel = value; }
    }   

    public int IdleTime
    {
        get { return idleTime; }
        set { idleTime = value; }
    }   

    public int HoursTalk
    {
        get { return hoursTalk ; }
        set { hoursTalk  = value; }
    }
    
    

}

