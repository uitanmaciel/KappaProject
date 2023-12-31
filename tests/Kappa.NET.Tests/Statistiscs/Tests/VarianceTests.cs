﻿using Kappa.NET.Tests.Statistiscs.Data;

namespace Kappa.NET.Tests.Statistiscs.Tests;

[TestClass]
public class VarianceTests
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
    public void VarianceCalculateTest()
    {
        var variance = statistic.Variance(data.X);
        Assert.AreEqual(0.867224281943798, Math.Round(variance, 15));
    }
}
