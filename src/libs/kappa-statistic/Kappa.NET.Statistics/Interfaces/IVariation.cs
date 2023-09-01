namespace Kappa.NET.Statistics.Interfaces;

public interface IVariation
{
    /// <summary>
    /// Calculates the coefficient of variation of a dataset.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the coefficient of variation of a dataset.</returns>
    double Variation(double[] data);

    /// <summary>
    /// Calculates the coefficient of variation of a dataset.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the coefficient of variation of a dataset.</returns>
    Task<double> VariationAsync(double[] data);
}
