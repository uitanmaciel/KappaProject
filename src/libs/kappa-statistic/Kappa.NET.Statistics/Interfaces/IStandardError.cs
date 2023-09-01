namespace Kappa.NET.Statistics.Interfaces;

public interface IStandardError
{
    /// <summary>
    /// Calculates the standard error of a regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the standard error of a regression.</returns>
    double StandardError(double[] x, double[] y);
}
