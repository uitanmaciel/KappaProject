using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Median : EntityBase
{
    private double[] Values { get; set; }

    public Median(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double Med()
    {
        try
        {
            Array.Sort(Values);
            int n = Values.Length;
            double median = 0;

            if (n % 2 != 0)
                median = Values[n / 2];
            else
                median = (Values[n / 2 - 1] + Values[n / 2]) / 2;
            return median;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
