namespace HeadFirstDesignPatterns.strategy;

public abstract class Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
{
    public abstract void Display();
    
    public void SetFlyBehavior(IFlyBehavior fb) => flyBehavior = fb;
    public void SetQuackBehavior(IQuackBehavior qb) => quackBehavior = qb;

    public void PerformFly()
    {
        flyBehavior.Fly();
    }
    
    public void PerformQuack()
    {
        quackBehavior.Quack();
    }
    
    public void Swim() => Console.WriteLine("All ducks float, even decoys!");
}