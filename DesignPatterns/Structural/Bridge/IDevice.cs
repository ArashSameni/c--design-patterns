namespace DesignPatterns.Structural.Bridge;

public interface IDevice
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
    public void VolumeUp(int amount);
    public void VolumeDown(int amount);
}