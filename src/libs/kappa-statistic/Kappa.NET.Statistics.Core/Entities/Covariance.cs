﻿using Kappa.NET.Statistics.Core.Abstracts;

namespace Kappa.NET.Statistics.Core.Entities;

public sealed class Covariance : EntityBase
{
    private double[] X { get; set; }
    private double[] Y { get; set; }

    public Covariance(double[] x, double[] y) : base(x, y)
    {
        IsValid();
        X = x;
        Y = y;
    }

    public double Execute()
    {
        try
        {
            var meanX = new Mean(X).Arithmetic();
            var meanY = new Mean(Y).Arithmetic();
            double sum = 0d;

            for (int i = 0; i < X.Length; i++)
                sum += (X[i] - meanX) * (Y[i] - meanY);

            return sum / (X.Length - 1);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<double> ExecuteAsync()
    {
        try
        {
            var meanX = Task<double>.Run(() => new Mean(X).Arithmetic());
            var meanY = Task<double>.Run(() => new Mean(Y).Arithmetic());
            await Task.WhenAll(meanX, meanY);

            double sum = 0d;

            for (int i = 0; i < X.Length; i++)
                sum += (X[i] - meanX.Result) * (Y[i] - meanY.Result);

            return sum / (X.Length - 1);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
