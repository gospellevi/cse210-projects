class Program
{
    // Simple menu to test out the game classes.
    static void Main(string[] args)
    {
        
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Circle("red", 10));
        shapes.Add(new Rectangle("green", 5, 10));

        foreach (Shape shape in shapes)
        {
            // Console.WriteLine(shape.GetColor());
            // Console.WriteLine(shape.GetArea());

            Console.WriteLine($"Shape with {shape.GetColor()} color has an area of {shape.GetArea()}");
        }
        
    }
}