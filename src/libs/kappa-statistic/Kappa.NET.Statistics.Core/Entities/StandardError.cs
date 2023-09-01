using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class StandardError : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public StandardError(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Execute()
    {
        var yPredict = new Predict(X, Y).Execute();
        double sumY = 0.0;

        try
        {
            for (int i = 0; i < Y.Length; i++)
                sumY += Math.Pow(Y[i] - yPredict[i], 2);

            return Math.Sqrt(sumY / (Y.Length - 2));
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
