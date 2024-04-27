namespace HeadFirstDesignPatterns.strategy;

public class RedheadDuck() : Duck(new FlyWithWings(), new QuackBehavior())
{
    public override void Display() => Console.WriteLine("I'm a real Red Headed duck");
}