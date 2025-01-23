public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Explicitly initialize MyProperty
        MyProperty = 10; 
    }
    //Or another constructor with parameters
    public MyClass(int value){
        MyProperty = value;
    }
}