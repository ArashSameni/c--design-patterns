namespace DesignPatterns.Structural.Bridge;

public class SonyTv : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("SonyTv turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("SonyTv turned off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"SonyTv channel changed to {channel}");
    }

    public void VolumeUp(int amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount should be greater than 0");
        
        Console.WriteLine($"SonyTv volume up {amount}");
    }

    public void VolumeDown(int amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount should be greater than 0");
        
        Console.WriteLine($"SonyTv volume down {amount}");
    }
}