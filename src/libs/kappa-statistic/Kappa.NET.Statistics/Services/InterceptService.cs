namespace Kappa.NET.Statistics.Services;

public sealed class InterceptService : IIntercept
{
    public InterceptService() { }

    public double Intercept(double[] x, double[] y)
    {
        var intercept = new Intercept(x, y);
        return intercept.Execute();
    }
}
