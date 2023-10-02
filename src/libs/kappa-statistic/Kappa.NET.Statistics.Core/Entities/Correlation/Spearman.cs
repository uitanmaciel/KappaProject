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

    public double Execute()
    {
        return new Pearson(Ranker(X), Ranker(Y)).Execute();
    }

    public async Task<double> ExecuteAsync()
    {
        var spearman = await Task<double>.Run(() => new Pearson(Ranker(X), Ranker(Y)).ExecuteAsync());
        return spearman;        
    }

    private double[] Ranker(double[] data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));

        var ranks = new double[data.Length];
        var index = new int[data.Length];
        for (int i = 0; i < data.Length; i++)
            index[i] = i;

        Arrays.Sort(data, index);
        int previousIndex = 0;

        for(int i = 1; i < data.Length; i++)
        {
             if(Math.Abs(data[i] - data[previousIndex]) <= 0d)
                continue;
            
            if(i == previousIndex + 1)
            {
                ranks[index[previousIndex]] = i;                
            }
            else
            {
                RankerTies(ranks, index, previousIndex, i);                
            }
            previousIndex = i;
        }
        RankerTies(ranks, index, previousIndex, data.Length);
        return ranks;
    }

    private void RankerTies(double[] ranks, int[] index, int a, int b) 
    {
        double rank = (b + a - 1) / 2d + 1;
        for (int i = a; i < b; i++)
        {
            ranks[index[i]] = rank;
        }
    }
}
