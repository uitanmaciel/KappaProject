using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

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
        Assert.AreEqual(0.361957081027961, Math.Round(correlation.Result, 15));
    }

    [TestMethod]
    public void CorrelationKendallCalculateTest()
    {
        var correlation = statistic.Correlation.Kendall(data.X, data.Y);
        Assert.AreEqual(0.182318703791096, Math.Round(correlation, 15));
    }

    [TestMethod]
    public void CorrelationSpearmanCalculateTest()
    {
        var correlation = statistic.Correlation.Spearman(data.X, data.Y);
        Assert.AreEqual(0.261853749417792, Math.Round(correlation.Result, 15));
    }
}
