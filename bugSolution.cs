public class ExampleClass
{
    public int MyProperty { get; set; }
    public int AnotherProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
        AnotherProperty = 0; // Initialize AnotherProperty in the constructor
    }

    public void MyMethod()
    {
        Console.WriteLine(AnotherProperty); 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass obj = new ExampleClass(10);
        obj.MyMethod();
    }
} 