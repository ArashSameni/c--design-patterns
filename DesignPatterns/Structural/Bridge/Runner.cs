namespace DesignPatterns.Structural.Bridge;

public class Runner : IRunnable
{
    public void Run()
    {
        var sonyTv = new SonyTv();
        
        var remoteControl = new RemoteControl(sonyTv);
        remoteControl.TurnOn();
        remoteControl.TurnOff();

        var advancedRemoteControl = new AdvancedRemoteControl(sonyTv);
        advancedRemoteControl.TurnOn();
        advancedRemoteControl.SetChannel(5);
    }
}