namespace Kappa.NET.Tests.Tests;

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
        Assert.AreEqual<double>(0.131012928506282, Math.Round(rSquared, 15));
    }

    [TestMethod]
    public void RSquaredAdjustedCalculateTest()
    {
        var rSquared = statistic.Squares.RSquaredAdjusted(data.X, data.Y);
        Assert.AreEqual<double>(0.1233, Math.Round(rSquared, 4));
    }

    [TestMethod]
    public void SumSquareRegressionCalculateTest()
    {
        var sumReg = statistic.Squares.SumSquareRegression(data.X, data.Y);
        Assert.AreEqual<double>(12.7091486305791, Math.Round(sumReg, 13));
    }

    [TestMethod]
    public void SumSquareResidualsCalculateTest()
    {
        var sumRes = statistic.Squares.SumSquareResiduals(data.X, data.Y);
        Assert.AreEqual<double>(84.2976794395962, Math.Round(sumRes, 13));
    }

    [TestMethod]
    public void SumSquareCalculateTest()
    {
        var sumRes = statistic.Squares.SumSquare(data.X, data.Y);
        Assert.AreEqual<double>(97.006828070175, Math.Round(sumRes, 12));
    }
}
