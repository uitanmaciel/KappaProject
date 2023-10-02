using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public sealed class Squares : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Squares(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double RSquared()
    {
        try
        {
            return Math.Pow(new Kappa.NET.Statistics.Core.Entities.Correlation.Pearson(X, Y).Execute(), 2);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double RSquaredAdjusted(double k)
    {
        try
        {
            var rSquared = RSquared();
            return 1 - ((1 - rSquared) * (X.Length - 1) / (X.Length - k - 1));
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double SumSquareRegression()
    {
        var mean = new Mean(Y).Arithmetic();
        var yPredicted = new Predict(X, Y).Execute();       

        try
        {
            double sqe = 0.0;
            for (int i = 0; i < Y.Length; i++)
                sqe += Math.Pow(yPredicted[i] - mean, 2);
            return sqe;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double SumSquareResiduals()
    {
        var residuals = new Residuals(X, Y).Execute();
        try
        {
            double sqr = 0.0;
            for (int i = 0; i < Y.Length; i++)
                sqr += Math.Pow(residuals[i], 2);

            return sqr;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double Sum()
    {
        var sumReg = SumSquareRegression();
        var sumRes = SumSquareResiduals();
        return sumReg + sumRes;
    }

    public async Task<double> SumAsync()
    {
        try
        {
            var sumReg = Task<double>.Run(() => SumSquareRegression());
            var sumRes = Task<double>.Run(() => SumSquareResiduals());
            await Task.WhenAll(sumReg, sumRes);
            return sumReg.Result + sumRes.Result;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
