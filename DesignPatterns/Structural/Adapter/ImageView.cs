namespace DesignPatterns.Structural.Adapter;

public class ImageView
{
    private string _image;

    public ImageView(string image)
    {
        _image = image;
    }

    public void Apply(IFilter filter)
    {
        filter.Apply(_image);
    }
}