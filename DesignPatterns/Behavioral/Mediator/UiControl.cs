namespace DesignPatterns.Behavioral.Mediator;

public abstract class UiControl
{
    protected readonly Form Parent;

    protected UiControl(Form parent)
    {
        Parent = parent;
    }
}