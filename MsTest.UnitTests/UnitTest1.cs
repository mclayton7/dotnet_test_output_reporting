using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTest.UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestThatPassesWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestThatPassesWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestThatPassesWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestThatFailsWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.Fail();
    }

    [TestMethod]
    public void TestThatFailsWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [TestMethod]
    public void TestThatFailsWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [Ignore]
    [TestMethod]
    public void TestThatsSkippedWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        
    }

    [Ignore]
    [TestMethod]
    public void TestThatsSkippedWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }

    [Ignore]
    [TestMethod]
    public void TestThatsSkippedWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.Fail();
    }
}