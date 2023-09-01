using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Variance : EntityBase
{
    private double[] Values { get; set; }

    public Variance(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double Var()
    {
        try
        {
            double mean = new Mean(Values).Arithmetic();
            double sum = 0.0;

            foreach (double value in Values)
                sum += Math.Pow((value - mean), 2);

            return sum / (Values.Length - 1);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
