using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class SlopeTests
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
    public void SlopeCalculateTest()
    {
        var slope = statistic.Slope.Slope(data.X, data.Y);
        Assert.AreEqual(0.36013, Math.Round(slope, 5));
    }

    [TestMethod]
    public void SlopeAsyncCalculateTest()
    {
        var slope = statistic.Slope.SlopeAsync(data.X, data.Y);
        Assert.AreEqual(0.36013, Math.Round(slope.Result, 5));
    }

    [TestMethod]
    public void SlopeErrorCalculateTest()
    {
        var slopeError = statistic.Slope.Error(data.X, data.Y);
        Assert.AreEqual(0.08764, Math.Round(slopeError, 5));
    }

    [TestMethod]
    public void SlopeErrorAsyncCalculateTest()
    {
        var slopeError = statistic.Slope.ErrorAsync(data.X, data.Y);
        Assert.AreEqual(0.08764, Math.Round(slopeError.Result, 5));
    }
}
