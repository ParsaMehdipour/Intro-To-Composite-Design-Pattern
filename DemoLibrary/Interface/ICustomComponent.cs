namespace DemoLibrary.Interface;
public interface ICustomComponent
{
    void AddComponent(ICustomComponent component);

    decimal CalculatePrice();
}
