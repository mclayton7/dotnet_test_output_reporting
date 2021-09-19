using NUnit.Framework;
using System;

namespace NUnit.UnitTests;

[TestFixture]
public class Tests
{
    [TestCase]
    public void TestThatPassesWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.IsTrue(true);
    }

    [TestCase]
    public void TestThatPassesWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.IsTrue(true);
    }

    [TestCase]
    public void TestThatPassesWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.IsTrue(true);
    }

    [TestCase]
    public void TestThatFailsWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.Fail();
    }

    [TestCase]
    public void TestThatFailsWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [TestCase]
    public void TestThatFailsWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [Ignore("ignore")]
    [TestCase]
    public void TestThatsSkippedWithStdOut()
    {
        Console.WriteLine("Output to stdout");

    }

    [Ignore("ignore")]
    [TestCase]
    public void TestThatsSkippedWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [Ignore("ignore")]
    [TestCase]
    public void TestThatsSkippedWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }
}