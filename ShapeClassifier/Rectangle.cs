using System;

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width; Height = height;
    }

    public override string GetShape()
    {
        return $"직사각형({Width}x{Height})";
    }
}