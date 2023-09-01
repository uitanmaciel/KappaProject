namespace Kappa.NET.Tests.Tests;

[TestClass]
public class ModeTests
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
    public void ModeCalculateTest()
    {
        var mode = statistic.Mode(data.X);
        Assert.AreEqual(21.5000, Math.Round(mode[0], 4));
    }
}
