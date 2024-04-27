namespace HeadFirstDesignPatterns.strategy;

public class QuackBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("Quack");
}