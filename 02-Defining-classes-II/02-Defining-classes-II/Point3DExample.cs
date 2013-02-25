/* - Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * - Implement the ToString() to enable printing a 3D point.
 * - Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
 * - Add a static property to return the point O.
 * - Write a static class with a static method to calculate the distance between two points in the 3D space.
 * - Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice. 
*/

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
