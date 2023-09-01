namespace Kappa.NET.Statistics.Interfaces;

public interface IResiduals
{
    /// <summary>
    /// Calculates the residuals of an dataset.
    /// </summary>
    /// <param name="x">Dataset for x</param>
    /// <param name="y">Dataset for x</param>
    /// <returns>Returns the residuals of an dataset.</returns>
    double[] Residuals(double[] x, double[] y);

    /// <summary>
    /// Normalizes the residuals of a data set based on the standard deviation of Y.
    /// </summary>
    /// <param name="x">Dataset for x</param>
    /// <param name="y">Dataset for y</param>
    /// <returns>Returns the residuals of a data set based on the standard deviation of Y.</returns>
    double[] Normalize(double[] x, double[] y);
}
