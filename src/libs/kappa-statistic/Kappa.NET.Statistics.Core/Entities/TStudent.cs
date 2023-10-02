using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public sealed class TStudent : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public TStudent(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double TSlope()
    {
        try
        {
            var slope = new Slope(X, Y).Execute();
            var slopeError = new Slope(X, Y).Error();
            return slope / slopeError;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<double> TSlopeAsync()
    {
        try
        {
            var slope = Task<double>.Run(() => new Slope(X, Y).ExecuteAsync());
            var slopeError = Task<double>.Run(() => new Slope(X, Y).ErrorAsync());
            await Task.WhenAll(slope, slopeError);
            return slope.Result / slopeError.Result;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
