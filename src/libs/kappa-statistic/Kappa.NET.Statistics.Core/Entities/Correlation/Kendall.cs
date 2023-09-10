using Kappa.NET.Statistics.Core.Abstracts;
using System.Linq;

namespace Kappa.NET.Statistics.Core.Entities.Correlation;

public sealed class Kendall : EntityBase
{
    private double[] X { get; set; } = null!;
    private double[] Y { get; set; } = null!;

    public Kendall(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Calculate()
    {
        double concordantCount = 0.0, discordantCount = 0.0;       

        try
        {
            for (int i = 0; i < X.Length - 1; i++)
            {
                for (int j = i + 1; j < X.Length; j++)
                {
                    int xComparison = X[i].CompareTo(X[j]);
                    int yComparison = Y[i].CompareTo(Y[j]);

                    if (xComparison == yComparison)
                        concordantCount++;
                    else if (xComparison != 0 && yComparison != 0)
                        discordantCount++;
                }
            }            
            return (concordantCount - discordantCount) / (concordantCount + discordantCount);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
