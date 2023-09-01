using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Mode : EntityBase
{
    private double[] Values { get; set; }

    public Mode(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double[] Mod()
    {
        try
        {
            Dictionary<double, double> freq = new();
            foreach (var item in Values)
            {
                if (freq.ContainsKey(item))
                    freq[item]++;
                else
                    freq[item] = 1;
            }

            var max = freq.Max(x => x.Value);
            var modes = freq.Where(x => x.Value == max)
                            .Select(x => x.Key).ToArray();

            return modes;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
