namespace HeadFirstDesignPatterns.strategy;

public class MallardDuck() : Duck(new FlyWithWings(), new QuackBehavior())
{
    public override void Display() => Console.WriteLine("I'm a real Mallard duck");
}