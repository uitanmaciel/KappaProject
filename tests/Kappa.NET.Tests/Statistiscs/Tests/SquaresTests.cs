using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class SquaresTests
{
    private Dataset data = null!;
    private Statistic statistic = null!;

    [TestInitialize]
    public void Initialize()
    {
        data = new Dataset();
        statistic = new Statistic();
    }

    [TestMethod]
    public void RSquaredCalculateTest()
    {
        var rSquared = statistic.Squares.RSquared(data.X, data.Y);
        Assert.AreEqual(0.131012928506282, Math.Round(rSquared, 15));
    }

    [TestMethod]
    public void RSquaredAdjustedCalculateTest()
    {
        var rSquared = statistic.Squares.RSquaredAdjusted(data.X, data.Y);
        Assert.AreEqual(0.1233, Math.Round(rSquared, 4));
    }

    [TestMethod]
    public void SumSquareRegressionCalculateTest()
    {
        var sumReg = statistic.Squares.SumSquareRegression(data.X, data.Y);
        Assert.AreEqual(12.7091486305791, Math.Round(sumReg, 13));
    }

    [TestMethod]
    public void SumSquareResidualsCalculateTest()
    {
        var sumRes = statistic.Squares.SumSquareResiduals(data.X, data.Y);
        Assert.AreEqual(84.2976794395962, Math.Round(sumRes, 13));
    }

    [TestMethod]
    public void SumCalculateTest()
    {
        var sum = statistic.Squares.Sum(data.X, data.Y);
        Assert.AreEqual(97.006828070175, Math.Round(sum, 12));
    }

    [TestMethod]
    public void SumAsyncCalculateTest()
    {
        var sum = statistic.Squares.SumAsync(data.X, data.Y);
        Assert.AreEqual(97.006828070175, Math.Round(sum.Result, 12));
    }
}
