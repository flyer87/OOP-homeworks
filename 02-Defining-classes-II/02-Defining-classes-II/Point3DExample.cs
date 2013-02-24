using System;

class Point3DExample
{
    static void Main()
    {
        //Point3D myPoint1 = Point3D.ZeroPoint;
        //Console.WriteLine(myPoint1);

        //Point3D myPoint2 = new Point3D(3, 3, 3);


        //Console.WriteLine(Point3DDistance.CalcTwoPointDistance(myPoint1, myPoint2));

        //Path myPath = new Path();
        //myPath.ClearPoints();

        Path myPath = PathStorage.LoadFromFile("fileForLoad.txt");
        foreach (Point3D point in myPath.PointsList)
        {
            Console.WriteLine(point);
        }



    }
}
