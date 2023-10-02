namespace Kappa.NET.Statistics.Services;

public sealed class TStudentService : ITStudent
{
    public TStudentService() { }

    public double Slope(double[] x, double[] y)
    {
        var tStudent = new TStudent(x, y);
        return tStudent.TSlope();
    }

    public async Task<double> SlopeAsync(double[] x, double[] y)
    {
        var tStudent = new TStudent(x, y);
        return await tStudent.TSlopeAsync();
    }
}
