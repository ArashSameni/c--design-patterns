namespace DesignPatterns.Behavioral.Mediator;

public class DialogForm : Form
{
    public TextBox NameTextBox { get; }
    public Button SaveButton { get; }

    public DialogForm()
    {
        NameTextBox = new TextBox(this);
        SaveButton = new Button(this, "Save");
    }

    public override void OnChange(UiControl uiControl)
    {
        if (uiControl == NameTextBox)
            HandleNameTextBoxChange();
    }

    private void HandleNameTextBoxChange()
    {
        SaveButton.IsEnabled = !string.IsNullOrWhiteSpace(NameTextBox.Text);
    }
}