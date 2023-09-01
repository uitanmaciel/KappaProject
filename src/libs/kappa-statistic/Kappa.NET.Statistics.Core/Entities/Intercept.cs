using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Intercept : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Intercept(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Execute()
    {
        double slope = new Slope(X, Y).Execute();
        try
        {
            return (Y.Sum() - (slope * X.Sum())) / X.Length;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double Error()
    {
        return 0.0;
    }
}
