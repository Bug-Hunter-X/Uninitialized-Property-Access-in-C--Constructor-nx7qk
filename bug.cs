public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a property that is not initialized in the constructor can lead to unexpected behavior.
        Console.WriteLine(AnotherProperty); 
    }

    public int AnotherProperty { get; set; } 
}

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass obj = new ExampleClass(10);
        obj.MyMethod();
    }
}