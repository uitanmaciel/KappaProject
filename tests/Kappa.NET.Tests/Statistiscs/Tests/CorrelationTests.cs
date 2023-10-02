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
    public void CorrelationPearsonAsyncCalculateTest()
    {
        var correlation = statistic.Correlation.PearsonAsync(data.X, data.Y);
        Assert.AreEqual(0.361957081027961, Math.Round(correlation.Result, 15));        
    }

    [TestMethod]
    public void CorrelationPearsonCalculateTest()
    {
        var correlation = statistic.Correlation.Pearson(data.X, data.Y);
        Assert.AreEqual(0.361957081027961, Math.Round(correlation, 15));
    }

    [TestMethod]
    public void CorrelationKendallCalculateTest()
    {
        double[] x = { 19.65, 19.70, 19.87, 19.35, 18.75, 19.99, 19.20, 19.99, 18.75, 19.70 };
        double[] y = { 31.95, 32.23, 32.12, 31.13, 31.51, 32.12, 30.84, 30.77, 32.23, 31.03 };

        var correlation = statistic.Correlation.Kendall(data.X, data.Y);
        Assert.AreEqual(0.180610416737801, Math.Round(correlation, 15));
    }

    public void CorrelationSpearmanCalculateTest()
    {
        var correlation = statistic.Correlation.Spearman(data.X, data.Y);
        Assert.AreEqual(0.259990441319409, Math.Round(correlation, 15));
    }

    [TestMethod]
    public void CorrelationSpearmanAsyncCalculateTest()
    {
        var correlation = statistic.Correlation.SpearmanAsync(data.X, data.Y);
        Assert.AreEqual(0.259990441319409, Math.Round(correlation.Result, 15));
    }
}
