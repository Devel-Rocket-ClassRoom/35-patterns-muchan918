using System;

class Square : Shape
{
    public int Side { get; set; }

    public Square(int side)
    {
        Side = side; 
    }

    public override string GetShape()
    {
        return $"정사각형({Side})";
    }
}