namespace Kappa.NET.Statistics.Services;

public sealed class CorrelationService : ICorrelation
{
    public CorrelationService() { }

    public async Task<double> Pearson(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Pearson(x, y);
        return await correlation.Calculate();
    }

    public double Kendall(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Kendall(x, y);
        return correlation.Calculate();
    }

    public async Task<double> Spearman(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Spearman(x, y);
        return await correlation.Calculate();
    }
}
