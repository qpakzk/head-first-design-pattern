namespace HeadFirstDesignPatterns.factory;

public class ChicagoStylePepperoniPizza() : Pizza("Chicago Style Pepperoni Pizza", "Extra Thick Crust Dough",
    "Plum Tomato Sauce", new List<string> { "Shredded Mozzarella Cheese", "Black Olives", "Spinach", "Eggplant", "Sliced Pepperoni" })
{
    public void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}