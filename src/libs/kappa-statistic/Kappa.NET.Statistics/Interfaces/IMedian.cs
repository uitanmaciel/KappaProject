namespace Kappa.NET.Statistics.Interfaces;

public interface IMedian
{
    /// <summary>
    /// Calculates the median of a data set.
    /// </summary>
    /// <param name="data">Dataset.</param>
    /// <returns>Returns the median of a data set.</returns>
    double Median(double[] data);
}
