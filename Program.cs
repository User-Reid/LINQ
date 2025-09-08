

Console.ReadKey();

public class Exercise
    {
    public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans) => timeSpans.Average(timespan => timespan.TotalMilliseconds);
    }