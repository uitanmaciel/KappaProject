using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class StandardDeviation : EntityBase
{
    private double[] Values { get; set; }

    public StandardDeviation(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double Std()
    {
        return Math.Sqrt(new Variance(Values).Var());
    }
}
