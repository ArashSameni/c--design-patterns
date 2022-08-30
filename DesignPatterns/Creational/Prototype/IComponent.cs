namespace DesignPatterns.Creational.Prototype;

// Prototype
public interface IComponent
{
    public void Render();
    public IComponent Clone();
}