namespace Kappa.NET.Tests.Tests;

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
        Assert.AreEqual<double>(4.41016443912488, Math.Round(variation, 14));
    }
}
