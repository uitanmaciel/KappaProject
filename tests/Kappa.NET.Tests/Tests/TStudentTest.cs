﻿namespace Kappa.NET.Tests.Tests;

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
        Assert.AreEqual<double>(4.109, Math.Round(tSlope, 3));
    }
}
