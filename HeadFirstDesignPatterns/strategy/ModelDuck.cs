namespace HeadFirstDesignPatterns.strategy;

public class ModelDuck() : Duck(new FlyNoWay(), new QuackBehavior())
{
    public override void Display() => Console.WriteLine("I'm a model duck");
}