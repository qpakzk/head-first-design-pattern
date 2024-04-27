namespace HeadFirstDesignPatterns.strategy;

public class SqueakBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("Squeak");
}