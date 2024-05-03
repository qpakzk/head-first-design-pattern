namespace HeadFirstDesignPatterns.factory;

public class ChicagoStyleCheesePizza() : Pizza("Chicago Style Deep Dish Cheese Pizza", "Extra Thick Crust Dough",
    "Plum Tomato Sauce", new List<string> { "Shredded Mozzarella Cheese" })
{
    public void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}