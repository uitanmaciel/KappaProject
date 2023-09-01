namespace Kappa.NET.Tests.Tests;

[TestClass]
public class CorrelationTests
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
    public void CorrelationPearsonCalculateTest()
    {
        var correlation = statistic.Correlation.Pearson(data.X, data.Y);
        Assert.AreEqual<double>(0.361957081027961, Math.Round(correlation, 15));
    }

    [TestMethod]
    public void CorrelationPearsonAsyncCalculateTest()
    {
        var correlation = statistic.Correlation.PearsonAsync(data.X, data.Y);
        Assert.AreEqual<double>(0.361957081027961, Math.Round(correlation.Result, 15));
    }
}
