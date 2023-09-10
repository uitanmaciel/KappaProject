using Kappa.NET.Statistics.Core.Abstracts;
using System.Linq;

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
        var sortedX = X.Select((value, index) => new { Value = value, OriginIndex = index })
                       .OrderBy(item => item.Value)
                       .Select((value, index) => new { Index = index + 1, Value = value })
                       .OrderBy(item => item.Value.OriginIndex)
                       .ToArray();

        var sortedY = Y.Select((value, index) => new { Value = value, OriginIndex = index })
                       .OrderBy(item => item.Value)
                       .Select((value, index) => new { Index = index + 1, Value = value })
                       .OrderBy(item => item.Value.OriginIndex)
                       .ToArray();

        double sumDiSquared = 0.0;

        for(int i = 0; i < sortedX.Length; i++) 
        {
            sumDiSquared += Math.Pow(sortedX[i].Index - sortedY[i].Index, 2);
        }

        double numerator = 6 * sumDiSquared;
        double denominator = X.Length * (Math.Pow(X.Length, 2) - 1);
        double result = 1 - (numerator / denominator);
        return 1 - (numerator / denominator);
    }
}
