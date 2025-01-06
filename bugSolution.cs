public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize to 0 in the declaration

    public MyClass() {
        MyProperty = 10; // or initialize in the constructor
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty.ToString());
    }
}