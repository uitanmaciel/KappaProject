namespace Kappa.NET.Statistics.Services;

public sealed class ResidualsService : IResiduals
{
    public ResidualsService() { }

    public double[] Normalize(double[] x, double[] y)
    {
        var residuals = new Residuals(x, y);
        return residuals.Normalize();
    }

    public double[] Residuals(double[] x, double[] y)
    {
        var residuals = new Residuals(x, y);
        return residuals.Execute();
    }
}
