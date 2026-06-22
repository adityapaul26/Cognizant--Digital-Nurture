using System;

class Program
{
    static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        if (years == 0)
            return currentValue;

        return PredictFutureValue(
            currentValue,
            growthRate,
            years - 1
        ) * (1 + growthRate);
    }

    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10; // 10%
        int years = 5;

        double futureValue =
            PredictFutureValue(
                currentValue,
                growthRate,
                years
            );

        Console.WriteLine(
            $"Predicted value after {years} years: {futureValue:F2}"
        );
    }
}
