using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class StandardDeviationTests
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
    public void StandardDeviationCalculateTest()
    {
        var std = statistic.StandardDeviation(data.X);
        Assert.AreEqual(0.931248775539489, Math.Round(std, 15));
    }
}
