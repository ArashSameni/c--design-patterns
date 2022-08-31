namespace DesignPatterns.Creational.Builder;

public class Presentation
{
    private readonly IList<Slide> _slides = new List<Slide>();

    public void AddSlide(Slide slide)
    {
        _slides.Add(slide);
    }

    public void Export(IPresentationBuilder builder)
    {
        foreach (var slide in _slides)
            builder.AddSlide(slide);
    }
}