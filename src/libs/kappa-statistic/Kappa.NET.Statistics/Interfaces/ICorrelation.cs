namespace Kappa.NET.Statistics.Interfaces;

public interface ICorrelation
{
    /// <summary>
    /// Computes the correlation coefficient of the Pearson.
    /// </summary>
    /// <param name="x">Dataset for x</param>
    /// <param name="y">Dataset for y</param>
    /// <returns>Returns the correlation coefficient of the Pearson.</returns>
    double Pearson(double[] x, double[] y);

    /// <summary>
    /// Computes the correlation coefficient of the Pearson.
    /// </summary>
    /// <param name="x">Dataset for x</param>
    /// <param name="y">Dataset for y</param>
    /// <returns>Returns the correlation coefficient of the Pearson.</returns>
    Task<double> PearsonAsync(double[] x, double[] y);
}
