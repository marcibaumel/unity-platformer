namespace study_platformer.Tests;
using NUnit.Framework;

public class UtilsTests
{
    [Test]
    public void Sum_Valid()
    {
        int expected = 3;
        int result = MathFunctions.Sum(1, 2);

        Assert.That(result ,Is.EqualTo(expected));
    }

        [Test]
    public void Sum_NotValid()
    {
        int expected = 3;
        int result = MathFunctions.Sum(2, 2);

        Assert.That(result ,Is.Not.EqualTo(expected));
    }
}
