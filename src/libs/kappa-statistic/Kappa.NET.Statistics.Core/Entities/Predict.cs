using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public sealed class Predict : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Predict(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double[] Execute()
    {
        double slope = new Slope(X, Y).Execute();
        double intercept = new Intercept(X, Y).Execute();
        List<double> predictList = new();

        try
        {
            foreach (var i in X)
                predictList.Add(slope * i + intercept);

            return predictList.ToArray();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<double[]> ExecuteAsync()
    {        
        var slope = Task.Run(() => { return new Slope(X, Y).ExecuteAsync(); });
        var intercept = Task.Run(() => { return new Intercept(X, Y).ExecuteAsync(); });
        await Task.WhenAll(slope, intercept);

        List<double> predictList = new();

        try
        {
            foreach (var i in X)
                predictList.Add(slope.Result * i + intercept.Result);

            return predictList.ToArray();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
