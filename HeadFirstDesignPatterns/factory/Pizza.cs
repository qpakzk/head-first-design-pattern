using System.Text;

namespace HeadFirstDesignPatterns.factory;

public abstract class Pizza(string name, string dough, string sauce, List<string> toppings)
{
    public string Name => name;
    public void Prepare() => Console.WriteLine($"Preparing {name}");
    public void Bake() => Console.WriteLine($"Baking {name}");
    public void Cut() => Console.WriteLine($"Cutting {name}");
    public void Box() => Console.WriteLine($"Boxing {name}");
    
    public override string ToString()
    {
        StringBuilder display = new StringBuilder();
        display.Append($"---- {name} ----\n");
        display.Append($"{dough}\n");
        display.Append($"{sauce}\n");
        foreach (string topping in toppings)
        {
            display.Append($"{topping}\n");
        }
        return display.ToString();
    }
}