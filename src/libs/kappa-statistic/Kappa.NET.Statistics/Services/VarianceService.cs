namespace Kappa.NET.Statistics.Services;

public sealed class VarianceService : IVariance
{
    public VarianceService() { }

    public double Variance(double[] data)
    {
        var variance = new Variance(data);
        return variance.Var();
    }
}
