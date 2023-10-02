namespace Kappa.NET.Statistics.Services;

public sealed class CorrelationService : ICorrelation
{
    public CorrelationService() { }

    public double Pearson(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Pearson(x, y);
        return correlation.Execute();
    }

    public async Task<double> PearsonAsync(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Pearson(x, y);
        return await correlation.ExecuteAsync();
    }

    public double Kendall(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Kendall(x, y);
        return correlation.Calculate();
    }

    public double Spearman(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Spearman(x, y);
        return correlation.Execute();
    }

    public async Task<double> SpearmanAsync(double[] x, double[] y)
    {
        var correlation = new Kappa.NET.Statistics.Core.Entities.Correlation.Spearman(x, y);
        return await correlation.ExecuteAsync();
    }
}
