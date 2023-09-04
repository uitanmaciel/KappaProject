using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class CovarianceTests
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
    public void CovarianceCalculateTest()
    {
        var covariance = statistic.Covariance(data.X, data.Y);
        Assert.AreEqual(0.312309160068312, Math.Round(covariance, 15));
    }
}
