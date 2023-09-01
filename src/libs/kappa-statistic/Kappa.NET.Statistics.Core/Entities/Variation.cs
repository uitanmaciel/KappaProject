using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public class Variation : EntityBase
{
    private double[] Values { get; set; }

    public Variation(double[] values) : base(values, null)
    {
        IsValid();
        Values = values;
    }

    public double Execute()
    {
        try
        {
            var mean = new Mean(Values).Arithmetic();
            var std = new StandardDeviation(Values).Std();
            return (std / mean) * 100;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<double> ExecuteAsync()
    {
        try
        {
            var mean = await Task<double>.Run(() => new Mean(Values).Arithmetic());
            var std = await Task<double>.Run(() => new StandardDeviation(Values).Std());
            
            return (std / mean) * 100;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
