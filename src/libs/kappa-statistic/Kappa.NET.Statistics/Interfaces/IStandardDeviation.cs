namespace Kappa.NET.Statistics.Interfaces;

public interface IStandardDeviation
{
    /// <summary>
    /// Calculates the standard deviation from a dataset.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the standard deviation from a dataset.</returns>
    double StandardDeviation(double[] data);
}
