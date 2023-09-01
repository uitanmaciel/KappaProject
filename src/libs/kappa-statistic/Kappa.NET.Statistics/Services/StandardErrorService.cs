namespace Kappa.NET.Statistics.Services;

public sealed class StandardErrorService : IStandardError
{
    public StandardErrorService() { }

    public double StandardError(double[] x, double[] y)
    {
        var stdError = new StandardError(x, y);
        return stdError.Execute();
    }
}
