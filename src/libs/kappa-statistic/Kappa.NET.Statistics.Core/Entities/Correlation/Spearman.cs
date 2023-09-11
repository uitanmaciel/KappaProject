using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities.Correlation;

public sealed class Spearman : EntityBase
{
    private double[] X { get; set; } = null!;
    private double[] Y { get; set; } = null!;

    public Spearman(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public async Task<double> Calculate()
    {
        var sortedX = Task<double[]>.Run(() => Sort(X));
        var sortedY = Task<double[]>.Run(() => Sort(Y));
        await Task.WhenAll(sortedX, sortedY);

        double sumDiSquared = 0.0;

        for(int i = 0; i < sortedX.Result.Length; i++) 
        {
            sumDiSquared += Math.Pow(sortedX.Result[i].Index - sortedY.Result[i].Index, 2);
        }        
        return 1 - ((6 * sumDiSquared) / (X.Length * (Math.Pow(X.Length, 2) - 1)));
    }

    private dynamic Sort(double[] data)
    {
        var order = data.Select((value, index) => new { Value = value, OriginIndex = index })
                       .OrderBy(item => item.Value)
                       .Select((value, index) => new { Index = index + 1, Value = value })
                       .OrderBy(item => item.Value.OriginIndex)
                       .ToArray();
        return order;
    }
}
