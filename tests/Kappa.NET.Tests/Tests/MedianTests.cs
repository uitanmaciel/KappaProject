namespace Kappa.NET.Tests.Tests;

[TestClass]
public class MedianTests
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
    public void MedianCalculateTest()
    {
        var median = statistic.Median(data.X);
        Assert.AreEqual<double>(21.2050, Math.Round(median, 4));
    }
}
