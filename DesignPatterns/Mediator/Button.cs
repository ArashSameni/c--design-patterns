namespace DesignPatterns.Mediator;

public class Button : UiControl
{
    public string Text { get; set; } = string.Empty;
    public bool IsEnabled { get; set; }
    
    public Button(Form parent, string? text = null) : base(parent)
    {
        if (text != null)
            Text = text;
    }
}