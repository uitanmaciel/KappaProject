using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities.Correlation;

public sealed class Pearson : EntityBase
{
    private double[] X { get; set; } = null!;
    private double[] Y { get; set; } = null!;

    public Pearson(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public async Task<double> Calculate()
    {
        try
        {
            var stdX = Task<double>.Run(() => new StandardDeviation(X).Std());
            var stdY = Task<double>.Run(() => new StandardDeviation(Y).Std());
            var covariance = Task<double>.Run(() => new Covariance(X, Y).Covar());
            await Task.WhenAll(stdX, stdY, covariance);
            return covariance.Result / (stdX.Result * stdY.Result);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
