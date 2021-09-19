using System;
using Xunit;

namespace XUnit.UnitTests;

public class UnitTest1
{
    [Fact]
    public void TestThatPassesWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.True(true);
    }

    [Fact]
    public void TestThatPassesWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(true);
    }

    [Fact]
    public void TestThatPassesWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(true);
    }

    [Fact]
    public void TestThatFailsWithStdOut()
    {
        Console.WriteLine("Output to stdout");
        Assert.True(false, "test failure");
    }

    [Fact]
    public void TestThatFailsWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(false, "test failure");
    }

    [Fact]
    public void TestThatFailsWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(false, "test failure");
    }

    [Fact(Skip = "skipping")]
    public void TestThatsSkippedWithStdOut()
    {
        Console.WriteLine("Output to stdout");

    }

    [Fact(Skip = "skipping")]
    public void TestThatsSkippedWithStdErr()
    {
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(false, "test failure");
    }

    [Fact(Skip = "skipping")]
    public void TestThatsSkippedWithStdOutAndStdErr()
    {
        Console.WriteLine("Output to stdout");
        Console.WriteLine("Output to stderr", Console.Error);
        Assert.True(false, "test failure");
    }
}