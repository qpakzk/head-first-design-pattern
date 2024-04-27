namespace HeadFirstDesignPatterns.strategy;

public class FlyNoWay : IFlyBehavior
{
    public void Fly() => Console.WriteLine("I cannot fly");
}