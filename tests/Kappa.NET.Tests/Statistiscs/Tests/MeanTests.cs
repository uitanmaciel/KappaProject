using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class MeanTests
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
    public void MeanArithmeticCalculateTest()
    {
        var mean = statistic.Mean.Arithmetic(data.X);
        Assert.AreEqual(21.1159649122807, Math.Round(mean, 13));
    }

    [TestMethod]
    public void MeanGeometricCalculateTest()
    {
        var mean = statistic.Mean.Geometric(data.X);
        Assert.AreEqual(21.0953251071075, Math.Round(mean, 13));
    }

    [TestMethod]
    public void MeanHarmonicCalculateTest()
    {
        var mean = statistic.Mean.Harmonic(data.X);
        Assert.AreEqual(21.074394073019, Math.Round(mean, 13));
    }

    [TestMethod]
    public void MeanWeightCalculateTest()
    {
        double[] values = { 100, 200, 200, 300, 400 };
        double[] weights = { 19.20, 18.22, 19.98, 20.55, 21.52 };

        var mean = statistic.Mean.Weighted(values, weights);
        Assert.AreEqual(20.2775, Math.Round(mean, 4));
    }

}
