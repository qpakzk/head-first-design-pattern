namespace HeadFirstDesignPatterns.strategy;

public class FakeQuackBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("Qwak");
}