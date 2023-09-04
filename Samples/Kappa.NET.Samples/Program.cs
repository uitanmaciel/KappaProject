using Kappa.NET;
using Kappa.NET.Samples;

var statistic = new Statistic();

/* Mean Sample */
var mean = statistic.Mean.Arithmetic(Dataset.X);
Console.WriteLine($"The mean to series is: {Math.Round(mean, 4)}");

/* Median Sample */
var median = statistic.Median(Dataset.X);
Console.WriteLine($"The median to series is: {Math.Round(median, 4)}");

/* Mode Sample */
var modes = statistic.Mode(Dataset.X);
Console.WriteLine("The modes to series is: ");
foreach(var mode in modes)
    Console.WriteLine(mode);

/* Residuals | Residuals Normalized | Predict */
var residuals = statistic.Residuals.Residuals(Dataset.X, Dataset.Y);
var normalized = statistic.Residuals.Normalize(Dataset.X, Dataset.Y);
var predict = statistic.Predict(Dataset.X, Dataset.Y);
Console.WriteLine("Residuals | Residuals Normalized | Predict");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"{Math.Round(residuals[i], 4)} | {Math.Round(normalized[i], 4)} | {Math.Round(predict[i], 4)}");
}
