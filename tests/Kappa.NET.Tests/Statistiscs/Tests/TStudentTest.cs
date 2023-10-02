using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class TStudentTest
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
    public void TSlopeCalculateTest()
    {
        var tSlope = statistic.TStudent.Slope(data.X, data.Y);
        Assert.AreEqual(4.109, Math.Round(tSlope, 3));
    }

    [TestMethod]
    public void TSlopeAsyncCalculateTest()
    {
        var tSlope = statistic.TStudent.SlopeAsync(data.X, data.Y);
        Assert.AreEqual(4.109, Math.Round(tSlope.Result, 3));
    }
}
