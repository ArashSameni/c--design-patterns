namespace DesignPatterns.Structural.Bridge;

public class RemoteControl
{
    protected readonly IDevice Device;

    public RemoteControl(IDevice device)
    {
        Device = device;
    }

    public void TurnOn()
    {
        Device.TurnOn();
    }
    
    public void TurnOff()
    {
        Device.TurnOff();
    }
}