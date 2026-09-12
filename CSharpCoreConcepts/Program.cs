using CSharpCoreConcepts.Concepts;
using CSharpCoreConcepts.Concepts.Extensions;

public class Program
{
    public static void Main()
    {
        Polymorphism anotherString = new AnotherPolymorphism();
        Console.WriteLine(anotherString.SayHello());
        Console.WriteLine($"Palindrome: {"sam".IsPalindrome()}");
    }
}