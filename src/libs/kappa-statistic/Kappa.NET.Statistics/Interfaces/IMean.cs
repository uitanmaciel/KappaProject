namespace Kappa.NET.Statistics.Interfaces;

public interface IMean
{
    /// <summary>
    /// Computes the simple arithmetic mean of a data set.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the simple arithmetic mean of a data set.</returns>
    double Arithmetic(double[] data);

    /// <summary>
    /// Computes the geometric mean of a data set.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the geometric mean of a data set.</returns>
    double Geometric(double[] data);

    /// <summary>
    /// Computes the harmonic mean of a data set.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the harmonic mean of a data set.</returns>
    double Harmonic(double[] data);

    /// <summary>
    /// Computes the weighted average of a data set.
    /// </summary>
    /// <param name="data">Dataset values</param>
    /// <param name="weights">Dataset weights</param>
    /// <returns>Returns the weighted average of a data set</returns>
    double Weighted(double[] data, double[] weights);
}
