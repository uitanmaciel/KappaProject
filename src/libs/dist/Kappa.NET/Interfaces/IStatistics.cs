using Kappa.NET.Statistics.Interfaces;

namespace Kappa.NET.Interfaces;

public interface IStatistics
{
    ICorrelation Correlation { get; }

    /// <summary>
    /// /// <summary>
    /// Computes the covariance of the data sets.
    /// </summary>
    /// <param name="x">Dataset to x</param>
    /// <param name="y">Dataset to y</param>
    /// <returns>Returns the covarianceof the data sets.</returns>
    double Covariance(double[] x, double[] y);

    /// <summary>
    /// /// <summary>
    /// Computes the covariance of the data sets.
    /// </summary>
    /// <param name="x">Dataset to x</param>
    /// <param name="y">Dataset to y</param>
    /// <returns>Returns the covarianceof the data sets.</returns>
    Task<double> CovarianceAsync(double[] x, double[] y);

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

    IMean Mean { get; }

    /// <summary>
    /// Calculates the median of a data set.
    /// </summary>
    /// <param name="data">Dataset.</param>
    /// <returns>Returns the median of a data set.</returns>
    double Median(double[] data);

    /// <summary>
    /// Finds the most repeating number (mode) in a data set.
    /// </summary>
    /// <param name="data">Dataset.</param>
    /// <returns>
    /// Returns the most repeating number (mode) in a data set.
    /// The return can be an array containing the modes or a mode.
    /// </returns>
    double[] Mode(double[] data);

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

    IResiduals Residuals { get; }
    ISlope Slope { get; }
    ISquares Squares { get; }

    /// <summary>
    /// Calculates the standard deviation from a dataset.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the standard deviation from a dataset.</returns>
    double StandardDeviation(double[] data);

    /// <summary>
    /// Calculates the standard error of a regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the standard error of a regression.</returns>
    double StandardError(double[] x, double[] y);

    ITStudent TStudent { get; }

    /// <summary>
    /// Computes the variance of a data set.
    /// </summary>
    /// <param name="data">Dataset</param>
    /// <returns>Returns the variance of a data set.</returns>
    double Variance(double[] data);

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
