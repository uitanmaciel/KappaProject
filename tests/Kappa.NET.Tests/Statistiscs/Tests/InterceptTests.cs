using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class InterceptTests
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
    public void InterceptCalculateTest()
    {
        var intercept = statistic.Intercept(data.X, data.Y);
        Assert.AreEqual(25.29438, Math.Round(intercept, 5));
    }

    public void InterceptAsyncCalculateTest()
    {
        var intercept = statistic.InterceptAsync(data.X, data.Y);
        Assert.AreEqual(25.29438, Math.Round(intercept.Result, 5));
    }
}
