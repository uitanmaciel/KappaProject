﻿namespace Kappa.NET.Tests.Tests;

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
        Assert.AreEqual<double>(25.29438, Math.Round(intercept, 5));
    }
}
