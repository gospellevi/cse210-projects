using System;

// See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class Shape
{
    private string _color = "";


    public Shape(string color)
    {
        _color = color;
    }


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // We can declare the function as an "abstract" function. That means
    // that it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from Shape. Then, any class that has an abstract method
    // must also be declared to be abstract.
    public abstract double GetArea();
}

