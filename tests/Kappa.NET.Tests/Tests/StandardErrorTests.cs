namespace Kappa.NET.Tests.Tests;

[TestClass]
public class StandardErrorTests
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
    public void StandardErrorCalculateTest()
    {
        var stdError = statistic.StandardError(data.X, data.Y);
        Assert.AreEqual<double>(0.8676, Math.Round(stdError, 4));
    }
}
