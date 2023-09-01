namespace Kappa.NET.Statistics.Core.Abstracts;

public abstract class EntityBase
{
    private double[] X { get; set; }
    private double[]? Y { get; set; }

    public EntityBase(double[] x, double[]? y)
    {
        X = x;
        Y = y;
    }

    public bool IsValid()
    {
        if (Y != null)
            return X.Length == Y.Length ? true : throw new Exception("The size of the datasets cannot be different.");

        return X.Length >= 0 ? true : throw new Exception("The dataset size must be greater than zero.");
    }
}
