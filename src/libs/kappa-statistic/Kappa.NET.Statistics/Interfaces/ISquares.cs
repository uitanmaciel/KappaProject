namespace Kappa.NET.Statistics.Interfaces;

public interface ISquares
{
    /// <summary>
    /// Computes the coefficient of determination (R²) of an double data set.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Return the coefficient of determination (R²) of an double data set.</returns>
    double RSquared(double[] x, double[] y);

    /// <summary>
    /// Computes the coefficient of determination modified (R² adjusted) of an double data set.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <param name="k">Number of variables excluding the result. The default is 1.</param>
    /// <returns>Returns the coefficient of determination modified (R² adjusted) of an double data set.</returns>
    double RSquaredAdjusted(double[] x, double[] y, double k = 1);

    /// <summary>
    /// Calculates the sum of squares of a simple linear regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the sum of squares of a simple linear regression.</returns>
    double SumSquareRegression(double[] x, double[] y);

    /// <summary>
    /// Calculates the sum of squares of the residuals from a simple linear regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Reeturns the sum of squares of the residuals from a simple linear regression.</returns>
    double SumSquareResiduals(double[] x, double[] y);

    /// <summary>
    /// Calculates the sum of total squares of a simple regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the sum of total squares from a simple regression.</returns>
    double Sum(double[] x, double[] y);

    /// <summary>
    /// Calculates the sum of total squares of a simple regression.
    /// </summary>
    /// <param name="x">Dataset for X</param>
    /// <param name="y">Dataset for Y</param>
    /// <returns>Returns the sum of total squares from a simple regression.</returns>
    Task<double> SumAsync(double[] x, double[] y);
}
