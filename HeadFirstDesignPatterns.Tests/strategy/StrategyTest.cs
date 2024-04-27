using HeadFirstDesignPatterns.strategy;

namespace HeadFirstDesignPatterns.Tests.strategy;

public class StrategyTest
{
    [Test]
    public void Test1()
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.PerformQuack();
        mallardDuck.PerformFly();

        Duck modelDuck = new ModelDuck();
        modelDuck.Display();
        modelDuck.PerformFly();
        modelDuck.PerformQuack();

        Duck decoyDuck = new DecoyDuck();
        decoyDuck.Display();
        decoyDuck.PerformFly();
        decoyDuck.PerformQuack();


        Duck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.PerformFly();
        rubberDuck.PerformQuack();


        Duck duck = new MallardDuck();
        duck.Display();
        duck.PerformFly();
        duck.PerformQuack();

        duck.SetFlyBehavior(new FlyRocketPowered());
        duck.PerformFly();

        duck.SetQuackBehavior(new FakeQuackBehavior());
        duck.PerformQuack();
    }
}