using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Predict : EntityBase
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
        List<double> predictList = new();
        var slope = Task.Run(() => { return new Slope(X, Y).Execute(); });
        var intercept = Task.Run(() => { return new Intercept(X, Y).Execute(); });
        Task.WaitAll();

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
