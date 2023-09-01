using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Correlation : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Correlation(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Pearson()
    {
        try
        {
            var covariance = new Covariance(X, Y).Covar();
            var stdX = new StandardDeviation(X).Std();
            var stdY = new StandardDeviation(Y).Std();
            return covariance / (stdX * stdY);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<double> PearsonAsync()
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
