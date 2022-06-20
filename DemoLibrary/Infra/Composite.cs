using DemoLibrary.Interface;

namespace DemoLibrary.Infra;
public class Composite : ICustomComponent
{
    public string Name { get; set; }
    public List<ICustomComponent> Components { get; set; } = new List<ICustomComponent>();

    public Composite(string name)
    {
        Name = name;
    }

    public void AddComponent(ICustomComponent component)
    {
        Components.Add(component);
    }

    public decimal CalculatePrice()
    {
        decimal price = 0;

        foreach (ICustomComponent component in Components)
        {
            price += component.CalculatePrice();
        }

        return price;
    }
}
