using ShapeLibrary;

var circle = new Circle(1);
var tr = new Triangle(3,4,5);
Console.WriteLine(tr.IsRightTriangle());


// я не до конца понял задание: "Вычисление площади фигуры без знания типа фигуры в compile-time"
//реализация 1
IShape figurA = DefineShape(6,3,5);
Console.WriteLine(figurA.CalcArea());
IShape figurB = DefineShape(6);
Console.WriteLine(figurB.CalcArea());

//реализация 2
List<IShape> shapes = new List<IShape>() {circle,tr };
foreach (var shape in shapes)
    Console.WriteLine(shape.CalcArea());


IShape DefineShape(params double[] parametrs)
{
    switch (parametrs.Length)
    {
        case 1:
            return new Circle(parametrs[0]);

        case 3:
            return new Triangle(parametrs[0], parametrs[1], parametrs[2]);
        default:
            return null;
    }
}