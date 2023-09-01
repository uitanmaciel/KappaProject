namespace Kappa.NET.Statistics.Services;

public sealed class VariationService : IVariation
{
    public VariationService() { }

    public double Variation(double[] data)
    {
        var variation = new Variation(data);
        return variation.Execute();
    }

    public Task<double> VariationAsync(double[] data)
    {
        var variation = new Variation(data);
        return variation.ExecuteAsync();
    }
}
