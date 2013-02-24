using System;

static class Point3DDistance
{
    public static double CalcTwoPointDistance(Point3D point1, Point3D point2)
    {
        return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2) + Math.Pow((point1.Z - point2.Z), 2));
    }
}
