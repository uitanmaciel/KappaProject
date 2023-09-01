namespace Kappa.NET.Statistics.Services;

public sealed class ModeService : IMode
{
    public ModeService() { }

    public double[] Mode(double[] data)
    {
        var mode = new Mode(data);
        return mode.Mod();
    }
}
