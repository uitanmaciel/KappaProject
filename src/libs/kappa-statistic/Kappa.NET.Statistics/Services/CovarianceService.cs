namespace Kappa.NET.Statistics.Services;

public sealed class CovarianceService : ICovariance
{
    public CovarianceService() { }

    public double Covariance(double[] x, double[] y)
    {
        var covariance = new Covariance(x, y);
        return covariance.Execute();
    }

    public async Task<double> CovarianceAsync(double[] x, double[] y)
    {
        var covariance = new Covariance(x, y);
        return await covariance.ExecuteAsync();
    }
}
