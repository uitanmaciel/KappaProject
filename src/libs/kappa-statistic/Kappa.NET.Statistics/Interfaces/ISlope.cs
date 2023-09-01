namespace Kappa.NET.Statistics.Interfaces;

public interface ISlope
{
    /// <summary>
    /// Calculates the slope (angular coefficient).
    /// </summary>
    /// <param name="x">Dataset for x</param>
    /// <param name="y">Dataset for x</param>
    /// <returns>Returns the slope (angular coefficient).</returns>
    double Slope(double[] x, double[] y);

    /// <summary>
    /// Calculates the standard error of the slope of a simple linear regression.
    /// </summary>
    /// <param name="x">Dataset values for X</param>
    /// <param name="y">Dataset values for Y</param>
    /// <returns>Returns the standard error of the slope of a simple linear regression.</returns>
    double Error(double[] x, double[] y);
}
