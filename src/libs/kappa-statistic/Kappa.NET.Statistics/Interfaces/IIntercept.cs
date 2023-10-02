namespace Kappa.NET.Statistics.Interfaces;

public interface IIntercept
{
    /// <summary>
    /// Calculates the intercept (linear coefficient).
    /// </summary>
    /// <param name="x">Dataset values for X</param>
    /// <param name="y">Dataset values for Y</param>
    /// <returns>Returns a number that corresponds to the intercept (linear coefficient).</returns>
    double Intercept(double[] x, double[] y);

    /// <summary>
    /// Calculates the intercept (linear coefficient).
    /// </summary>
    /// <param name="x">Dataset values for X</param>
    /// <param name="y">Dataset values for Y</param>
    /// <returns>Returns a number that corresponds to the intercept (linear coefficient).</returns>
    Task<double> InterceptAsync(double[] x, double[] y);
}
