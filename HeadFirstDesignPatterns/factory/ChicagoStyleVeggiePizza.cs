namespace HeadFirstDesignPatterns.factory;

public class ChicagoStyleVeggiePizza() : Pizza("Chicago Deep Dish Veggie Pizza", "Extra Thick Crust Dough",
    "Plum Tomato Sauce", new List<string> { "Shredded Mozzarella Cheese", "Black Olives", "Spinach", "Eggplant" })
{
    public void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}