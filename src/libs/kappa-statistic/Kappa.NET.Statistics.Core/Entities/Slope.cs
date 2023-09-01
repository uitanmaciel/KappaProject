using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Slope : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Slope(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Execute()
    {
        try
        {
            double xMean = new Mean(X).Arithmetic();
            double yMean = new Mean(Y).Arithmetic();
            double xy = 0.0, xSum = 0.0;

            for (int i = 0; i < X.Length; i++)
            {
                xy += (X[i] - xMean) * (Y[i] - yMean);
                xSum += Math.Pow(X[i] - xMean, 2);
            }
            return xy / xSum;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double Error()
    {
        var stdError = new StandardError(X, Y).Execute();
        var mean = new Mean(X).Arithmetic();
        double sum = 0.0;

        try
        {
            for (int i = 0; i < X.Length; ++i)
                sum += Math.Pow(X[i] - mean, 2);

            return stdError / Math.Sqrt(sum);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
