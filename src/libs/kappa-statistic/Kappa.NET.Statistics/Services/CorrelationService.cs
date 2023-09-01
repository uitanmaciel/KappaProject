using Kappa.NET.Statistics.Interfaces;

namespace Kappa.NET.Statistics.Services;

public sealed class CorrelationService : ICorrelation
{
    public CorrelationService() { }

    public double Pearson(double[] x, double[] y)
    {
        var correlation = new Correlation(x, y);
        return correlation.Pearson();
    }

    public Task<double> PearsonAsync(double[] x, double[] y)
    {
        var correlation = new Correlation(x, y);
        return correlation.PearsonAsync();
    }
}
