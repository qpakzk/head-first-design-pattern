namespace HeadFirstDesignPatterns.factory;

public class ChicagoStyleClamPizza() : Pizza("Chicago Style Clam Pizza", "Extra Thick Crust Dough",
    "Plum Tomato Sauce", new List<string> { "Shredded Mozzarella Cheese", "Frozen Clams from Chesapeake Bay" })
{
    public void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}