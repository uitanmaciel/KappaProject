namespace Kappa.NET.Statistics.Interfaces;

public interface IMode
{
    /// <summary>
    /// Finds the most repeating number (mode) in a data set.
    /// </summary>
    /// <param name="data">Dataset.</param>
    /// <returns>
    /// Returns the most repeating number (mode) in a data set.
    /// The return can be an array containing the modes or a mode.
    /// </returns>
    double[] Mode(double[] data);
}
