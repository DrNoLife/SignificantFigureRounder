namespace RoundToSignificantFactor.Library;

public static class RoundSigFigs
{
    public static double RoundToSignificantFactors(double num, int n)
    {
        if (n < 1)
        {
            throw new ArgumentException("n must be greater than or equal to 1");
        }

        if (num == 0)
        {
            return 0;
        }

        double d = Math.Ceiling(Math.Log10(num < 0 ? -num : num));
        int power = n - (int)d;

        double magnitude = Math.Pow(10, power);
        double shifted = Math.Round(num * magnitude);
        return shifted / magnitude;
    }
}
