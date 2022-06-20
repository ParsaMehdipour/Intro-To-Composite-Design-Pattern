using DemoLibrary.Interface;

namespace DemoLibrary.Infra;
public class Leaf : ICustomComponent
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Leaf(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public decimal CalculatePrice()
    {
        return Price;
    }

    public void AddComponent(ICustomComponent component)
    {
        throw new NotImplementedException();
    }
}
