namespace Kappa.NET.Statistics.Interfaces;

public interface IPredict
{
    /// <summary>
    /// Computes the optimal (expected) value for each value of Y in an data set.
    /// </summary>
    /// <param name="x">Dataset values for X</param>
    /// <param name="y">Dataset values for Y</param>
    /// <returns>Returns optimal (predicted) value for each Y value in an data set.</returns>
    double[] Predict(double[] x, double[] y);

    /// <summary>
    /// Computes the optimal (expected) value for each value of Y in an data set.
    /// </summary>
    /// <param name="x">Dataset values for X</param>
    /// <param name="y">Dataset values for Y</param>
    /// <returns>Returns optimal (predicted) value for each Y value in an data set.</returns>
    Task<double[]> PredictAsync(double[] x, double[] y);
}
