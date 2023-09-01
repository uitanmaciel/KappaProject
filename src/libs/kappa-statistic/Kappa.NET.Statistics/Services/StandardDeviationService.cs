namespace Kappa.NET.Statistics.Services;

public sealed class StandardDeviationService : IStandardDeviation
{
    public StandardDeviationService() { }

    public double StandardDeviation(double[] data)
    {
        var std = new StandardDeviation(data);
        return std.Std();
    }
}
