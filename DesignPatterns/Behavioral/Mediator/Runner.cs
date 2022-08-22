namespace DesignPatterns.Behavioral.Mediator;

public class Runner : IRunnable
{
    public void Run()
    {
        var dialogForm = new DialogForm();
        Console.WriteLine("Name: {0}, Button IsEnabled: {1}", dialogForm.NameTextBox.Text,
            dialogForm.SaveButton.IsEnabled);

        dialogForm.NameTextBox.Text = "Arash";
        
        Console.WriteLine("Name: {0}, Button IsEnabled: {1}", dialogForm.NameTextBox.Text,
            dialogForm.SaveButton.IsEnabled);
    }
}