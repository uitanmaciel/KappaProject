namespace Kappa.NET.Statistics.Services;

public sealed class MeanService : IMean
{
    public MeanService() { }

    public double Arithmetic(double[] data)
    {
        var mean = new Mean(data);
        return mean.Arithmetic();
    }

    public double Geometric(double[] data)
    {
        var mean = new Mean(data);
        return mean.Geometric();
    }

    public double Harmonic(double[] data)
    {
        var mean = new Mean(data);
        return mean.Harmonic();
    }

    public double Weighted(double[] data, double[] weights)
    {
        var mean = new Mean(data);
        return mean.Weighted(weights);
    }
}
