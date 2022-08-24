namespace DesignPatterns.Structural.Bridge;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public void SetChannel(int channel)
    {
        Device.SetChannel(channel);
    }

    public void VolumeUp(int amount)
    {
        Device.VolumeUp(amount);
    }
    
    public void VolumeDown(int amount)
    {
        Device.VolumeDown(amount);
    }
}