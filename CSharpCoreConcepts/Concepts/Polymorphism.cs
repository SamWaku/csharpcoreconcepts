namespace CSharpCoreConcepts.Concepts;


public class Polymorphism
{
    public virtual string SayHello() => "...";
}

public class AnotherPolymorphism : Polymorphism
{
    public override string SayHello() => "Hello";
}
