namespace Kappa.NET.Statistics.Services;

public sealed class MedianService : IMedian
{
    public MedianService() { }

    public double Median(double[] data)
    {
        return new Median(data).Med();
    }
}