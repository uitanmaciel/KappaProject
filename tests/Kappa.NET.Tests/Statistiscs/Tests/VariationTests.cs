using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class VariationTests
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
    public void VariationCalculate()
    {
        var variation = statistic.Variation(data.X);
        Assert.AreEqual(4.41016443912488, Math.Round(variation, 14));
    }

    [TestMethod]
    public void VariationAsyncCalculate()
    {
        var variation = statistic.VariationAsync(data.X);
        Assert.AreEqual(4.41016443912488, Math.Round(variation.Result, 14));
    }
}
