namespace Kappa.NET.Statistics.Interfaces;

public interface IVariance
{
    /// <summary>
    /// Computes the variance of a data set.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the variance of a data set.</returns>
    double Variance(double[] data);
}
