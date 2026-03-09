using System;

class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override string GetShape()
    {
        return $"원(반지름: {Radius})";
    }
}