using DesignPatterns.Structural.Adapter.ExternalLibrary;

namespace DesignPatterns.Structural.Adapter;

public class SpecialFilterAdapter : IFilter
{
    private readonly SpecialFilter _specialFilter;

    public SpecialFilterAdapter(SpecialFilter specialFilter)
    {
        _specialFilter = specialFilter;
    }

    public void Apply(string image)
    {
        _specialFilter.Initial(image);
        _specialFilter.Apply();
    }
}