using CSharpCoreConcepts.Concepts;

public class Program
{
    public static void Main()
    {
        Polymorphism anotherString = new AnotherPolymorphism();
        Console.WriteLine(anotherString.SayHello());
    }
}