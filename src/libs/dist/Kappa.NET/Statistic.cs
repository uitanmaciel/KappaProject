using Kappa.NET.Interfaces;
using Kappa.NET.Statistics.Interfaces;
using Kappa.NET.Statistics.Services;

namespace Kappa.NET;

public sealed class Statistic : IStatistics
{
    private ICovariance covariance;
    private IIntercept intercept;
    private IMedian median;
    private IMode mode;
    private IPredict predict;
    private IStandardDeviation std;
    private IStandardError stdError;
    private IVariance variance;
    private IVariation variation;

    public Statistic()
    {
        covariance = new CovarianceService();
        intercept = new InterceptService();
        median = new MedianService();
        mode = new ModeService();
        predict = new PredictService();
        std = new StandardDeviationService();
        stdError = new StandardErrorService();
        variance = new VarianceService();
        variation = new VariationService();
    }
    public ICorrelation Correlation => new CorrelationService();
    public IMean Mean => new MeanService();

    public IResiduals Residuals => new ResidualsService();

    public ISlope Slope => new SlopeService();

    public ISquares Squares => new SquaresService();

    public ITStudent TStudent => new TStudentService();

    public double Covariance(double[] x, double[] y)
    {
        return covariance.Covariance(x, y);
    }

    public double Intercept(double[] x, double[] y)
    {
        return intercept.Intercept(x, y); 
    }

    public double Median(double[] data)
    {
        return median.Median(data);
    }

    public double[] Mode(double[] data)
    {
        return mode.Mode(data);
    }

    public double[] Predict(double[] x, double[] y)
    {
        return predict.Predict(x, y);
    }

    public double StandardDeviation(double[] data)
    {
        return std.StandardDeviation(data);
    }

    public double StandardError(double[] x, double[] y)
    {
        return stdError.StandardError(x, y);
    }

    public double Variance(double[] data)
    {
        return variance.Variance(data);
    }

    public double Variation(double[] data)
    {
        return variation.Variation(data);
    }

    public Task<double> VariationAsync(double[] data)
    {
        return variation.VariationAsync(data);
    }    
}
