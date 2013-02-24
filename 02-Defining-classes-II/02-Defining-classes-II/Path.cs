using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Path
{
    private List<Point3D> pointsList = new List<Point3D>();

    // property 
    public List<Point3D> PointsList
    {
        get
        {
            return pointsList;
        }
    }

    public void AddPoint(Point3D point)
    {
        this.pointsList.Add(point);
    }

    public void ClearPoints()
    {
        this.pointsList.Clear();
    }


}