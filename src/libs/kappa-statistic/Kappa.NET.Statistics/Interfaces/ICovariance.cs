namespace Kappa.NET.Statistics.Interfaces;

public interface ICovariance
{
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

}
