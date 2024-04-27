namespace HeadFirstDesignPatterns.strategy;

public class MuteQuackBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("<<Silence>>");
}