namespace Kappa.NET.Statistics.Services;

public sealed class SlopeService : ISlope
{
    public SlopeService() { }

    public double Error(double[] x, double[] y)
    {
        var slope = new Slope(x, y);
        return slope.Error();
    }

    public double Slope(double[] x, double[] y)
    {
        var slope = new Slope(x, y);
        return slope.Execute();
    }
}
