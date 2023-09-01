namespace Kappa.NET.Statistics.Services;

public sealed class PredictService : IPredict
{
    public PredictService() { }

    public double[] Predict(double[] x, double[] y)
    {
        var predict = new Predict(x, y);
        return predict.Execute();
    }
}
