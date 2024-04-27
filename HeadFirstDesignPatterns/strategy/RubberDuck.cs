namespace HeadFirstDesignPatterns.strategy;

public class RubberDuck() : Duck(new FlyNoWay(), new SqueakBehavior())
{
    public override void Display() => Console.WriteLine("I'm a rubber duck");
}