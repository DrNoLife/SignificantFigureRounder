using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoundToSignificantFactor.Library;

namespace RoundToSignificantFactor.UnitTests;


[TestClass]
public class RoundSigFigsTests
{
    [TestMethod]
    public void TestRoundSigFigs_PositiveNumber()
    {
        double num = 123.4567;
        int n = 4;
        double expected = 123.5;
        double result = RoundSigFigs.RoundToSignificantFactors(num, n);
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void TestRoundSigFigs_NegativeNumber()
    {
        double num = -123.4567;
        int n = 4;
        double expected = -123.5;
        double result = RoundSigFigs.RoundToSignificantFactors(num, n);
        Assert.AreEqual(expected, result, 0.0001);
    }
    [TestMethod]
    public void TestRoundSigFigs_ZeroNumber()
    {
        double num = 0.0;
        int n = 4;
        double expected = 0.0;
        double result = RoundSigFigs.RoundToSignificantFactors(num, n);
        Assert.AreEqual(expected, result, 0.0001);
    }
    [TestMethod]
    public void TestRoundSigFigs_NumberWithLessSigFigs()
    {
        double num = 12.3;
        int n = 4;
        double expected = 12.3;
        double result = RoundSigFigs.RoundToSignificantFactors(num, n);
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void TestRoundSigFigs_NumberWithMoreSigFigs()
    {
        double num = 12.3456789;
        int n = 4;
        double expected = 12.35;
        double result = RoundSigFigs.RoundToSignificantFactors(num, n);
        Assert.AreEqual(expected, result, 0.0001);
    }
}
