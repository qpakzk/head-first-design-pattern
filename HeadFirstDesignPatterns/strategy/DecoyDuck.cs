namespace HeadFirstDesignPatterns.strategy;

public class DecoyDuck() : Duck(new FlyNoWay(), new MuteQuackBehavior())
{
    public override void Display() => Console.WriteLine("I'm a decoy duck");
}