namespace DesignPatterns.Mediator;

public class TextBox : UiControl
{
    private string _text = string.Empty;

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            Parent.OnChange(this);
        }
    }

    public TextBox(Form parent, string? text = null) : base(parent)
    {
        if (text != null)
            Text = text;
    }
}