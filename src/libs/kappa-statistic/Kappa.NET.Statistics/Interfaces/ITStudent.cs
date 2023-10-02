namespace Kappa.NET.Statistics.Interfaces;

public interface ITStudent
{
    /// <summary>
    /// Performs the statistc t of a slope.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the statistc t of a slope.</returns>
    double Slope(double[] x, double[] y);

    /// <summary>
    /// Performs the statistc t of a slope.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the statistc t of a slope.</returns>
    Task<double> SlopeAsync(double[] x, double[] y);
}
