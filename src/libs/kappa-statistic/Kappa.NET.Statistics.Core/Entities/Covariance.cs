using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Covariance : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Covariance(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Covar()
    {
        try
        {
            double meanX = new Mean(X).Arithmetic();
            double meanY = new Mean(Y).Arithmetic();
            double sum = 0.0;

            for (int i = 0; i < X.Length; i++)
                sum += (X[i] - meanX) * (Y[i] - meanY);

            return sum / (X.Length - 1);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
