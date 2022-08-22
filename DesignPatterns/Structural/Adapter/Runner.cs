using DesignPatterns.Structural.Adapter.ExternalLibrary;

namespace DesignPatterns.Structural.Adapter;

public class Runner : IRunnable
{
    public void Run()
    {
        var imageView = new ImageView("MyImage");
        
        imageView.Apply(new VividFilter());
        
        // Not Possible
        // imageView.Apply(new SpecialFilter());
        
        imageView.Apply(new SpecialFilterAdapter(new SpecialFilter()));
    }
}