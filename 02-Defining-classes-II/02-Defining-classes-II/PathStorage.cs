using System;
using System.IO;

static class PathStorage
{
    public static void SaveToFile(Path path)
    {
        string file = @"../../SavedPath.txt";
        StreamWriter writer = new StreamWriter(file);
        using (writer)
        {
            foreach (Point3D point in path.PointsList)
            {
                writer.WriteLine(point.X + ", " + point.Y + ", " + point.Z);
            }
        }
        Console.WriteLine("Path saved!");
    }

    public static Path LoadFromFile(string file)
    {
        StreamReader reader = new StreamReader(file);
        Path loadPath = new Path();
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] point = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                loadPath.AddPoint(new Point3D(Int32.Parse(point[0]), Int32.Parse(point[1]), Int32.Parse(point[2])));
            }
        }
        return loadPath;
    }
}
