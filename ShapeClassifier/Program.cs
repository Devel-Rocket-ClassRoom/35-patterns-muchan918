using System;

var shapes= new Shape[]
{
    new Circle(5),
    new Circle(15),
    new Rectangle(4,6),
    new Rectangle(5, 5),
    new Square(7)
};

Console.WriteLine("=== 도형 분류기 ===");
foreach(Shape shape in shapes)
{
    Console.WriteLine($"{shape.GetShape()}: {Classify(shape)}, 넓이: {CalculateArea(shape):f2}");
}

double CalculateArea(Shape s) => s switch
{
    Circle { Radius: var r } => r * r * Math.PI,
    Rectangle { Height: var h, Width: var w } => w * h,
    Square { Side: var side } => side * side,
    _ => 0
};

string Classify(Shape s) => s switch
{
    Circle { Radius: >= 10 } => "큰 원",
    Circle { Radius: < 10 } => "작은 원",
    Rectangle r when r.Width == r.Height => "정사각형 모양의 직사각형",
    Rectangle r when r.Width != r.Height => "일반 직사각형",
    Square => "정사각형",
    _ => "모양 없음"
};