using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public sealed class Mean : EntityBase
{
    private double[] Values { get; set; } = null!;

    public Mean(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double Arithmetic()
    {
        try
        {
            return Values.Sum() / Values.Length;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double Geometric()
    {
        try
        {
            double m = 1.0;
            foreach (var value in Values)
                m *= value;

            return Math.Pow(m, 1.0 / Values.Length);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public double Harmonic()
    {
        try
        {
            double sum = 0;
            for (int i = 0; i < Values.Length; i++)
                sum += 1.0 / Values[i];

            return Values.Length / sum;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public double Weighted(double[] weights)
    {
        try
        {
            double sum = 0.0;
            for (int i = 0; i < Values.Length; ++i)
                sum += (Values[i] * weights[i]);

            return sum / Values.Sum();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
