public struct Point3D
{
    // "publichno" pozwolqwam samo chetene; Imam PRIVATE set; => tochkite se zadawat samo s Constructor-a; sled sazdawane ne moje da se rachkat;
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);
    public static Point3D ZeroPoint
    {
        get
        {
            return zeroPoint;
        }
    }

    public override string ToString()
    {
        return string.Format("3D Point({0},{1},{2})", this.X, this.Y, this.Z);
    }
}
