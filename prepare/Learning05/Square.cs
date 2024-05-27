using System;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }


     // Using the override keyword here
    public override double GetArea()
    {
        return _side * _side;
        // throw new NotImplementedException();
    }
}