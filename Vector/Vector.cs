namespace Vector;

public struct Vector
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Magnitude => Math.Sqrt(X * X + Y * Y);

    // Direction in degrees
    public double Direction => Math.Atan2(Y, X) * (180.0 / Math.PI);

    // Instance methods 
    public Vector Add(Vector v)
    {
        return new Vector { X = this.X + v.X, Y = this.Y + v.Y };
    }

    public Vector Subtract(Vector v)
    {
        return new Vector { X = this.X - v.X, Y = this.Y - v.Y };
    }

    public double Dot(Vector v)
    {
        return this.X * v.X + this.Y * v.Y;
    }

    public double AngleBetween(Vector v)
    {
        double dot = this.Dot(v);
        double mags = this.Magnitude * v.Magnitude;
        if (mags == 0) return 0.0;
        return Math.Acos(dot / mags) * (180.0 / Math.PI); // degrees
    }

    public Vector Multiply(double scalar)
    {
        return new Vector { X = this.X * scalar, Y = this.Y * scalar };
    }

    public Vector Divide(double scalar)
    {
        if (scalar == 0) throw new DivideByZeroException("Cannot divide by zero");
        return new Vector { X = this.X / scalar, Y = this.Y / scalar };
    }

    public Vector Normalize()
    {
        double mag = this.Magnitude;
        if (mag == 0) return new Vector { X = 0, Y = 0 };
        return new Vector { X = this.X / mag, Y = this.Y / mag };
    }

    public override string ToString()
    {
        return $"<{X:0.##}, {Y:0.##}>";
    }

    // Class (static) methods 
    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

    public static Vector Multiply(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public static Vector Normalize(Vector v)
    {
        return v.Normalize();
    }

    // Overloaded operators 
    public static Vector operator +(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static Vector operator *(Vector v1, double scalar)
    {
        return v1.Multiply(scalar);
    }

    public static Vector operator /(Vector v1, double scalar)
    {
        return v1.Divide(scalar);
    }
}