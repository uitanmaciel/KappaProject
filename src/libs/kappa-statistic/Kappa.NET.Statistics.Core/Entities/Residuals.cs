using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Residuals : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Residuals(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double[] Execute()
    {
        List<double> residuals = new();
        var predicted = new Predict(X, Y).Execute();

        try
        {
            for (int i = 0; i < X.Length; i++)
                residuals.Add(Y[i] - predicted[i]);

            return residuals.ToArray();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double[] Normalize()
    {
        var exe = Execute();
        var std = new StandardDeviation(exe).Std();

        List<double> normalized = new();

        try
        {
            for (int i = 0; i < Y.Length; i++)
                normalized.Add(Normalizer(exe[i], std));

            return normalized.ToArray();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    private double Normalizer(double value, double factor)
    {
        return value / factor;
    }
}
