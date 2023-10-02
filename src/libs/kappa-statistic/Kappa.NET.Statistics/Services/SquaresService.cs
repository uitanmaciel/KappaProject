namespace Kappa.NET.Statistics.Services;

public sealed class SquaresService : ISquares
{
    public SquaresService() { }

    public double RSquared(double[] x, double[] y)
    {
        var square = new Squares(x, y);
        return square.RSquared();
    }

    public double RSquaredAdjusted(double[] x, double[] y, double k = 1)
    {
        var square = new Squares(x, y);
        return square.RSquaredAdjusted(k);
    }

    public double Sum(double[] x, double[] y)
    {
        var square = new Squares(x, y);
        return square.Sum();
    }

    public async Task<double> SumAsync(double[] x, double[] y)
    {
        var square = new Squares(x, y);
        return await square.SumAsync();
    }

    public double SumSquareRegression(double[] x, double[] y)
    {
        var square = new Squares(x, y);
        return square.SumSquareRegression();
    }

    public double SumSquareResiduals(double[] x, double[] y)
    {
        var square = new Squares(x, y);
        return square.SumSquareResiduals();
    }
}
