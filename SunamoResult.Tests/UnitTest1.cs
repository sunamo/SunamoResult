namespace SunamoResult.Tests;

/// <summary>
/// Unit tests for the SunamoResult library classes.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// Tests that ResultWithException stores data correctly when initialized with data.
    /// </summary>
    [Fact]
    public void ResultWithException_WithData_StoresData()
    {
        var result = new ResultWithException<int>(42);

        Assert.Equal(42, result.Data);
        Assert.Null(result.ExceptionMessage);
    }

    /// <summary>
    /// Tests that ResultWithException stores exception message when initialized with string.
    /// </summary>
    [Fact]
    public void ResultWithException_WithStringException_StoresMessage()
    {
        var result = new ResultWithException<int>("error occurred");

        Assert.Equal("error occurred", result.ExceptionMessage);
    }

    /// <summary>
    /// Tests that ResultWithException extracts message from Exception object.
    /// </summary>
    [Fact]
    public void ResultWithException_WithException_ExtractsMessage()
    {
        var exception = new InvalidOperationException("test error");
        var result = new ResultWithException<int>(exception);

        Assert.Equal("test error", result.ExceptionMessage);
    }

    /// <summary>
    /// Tests that empty ResultWithException constructor leaves both properties null or default.
    /// </summary>
    [Fact]
    public void ResultWithException_EmptyConstructor_BothPropertiesDefault()
    {
        var result = new ResultWithException<string>();

        Assert.Null(result.Data);
        Assert.Null(result.ExceptionMessage);
    }

    /// <summary>
    /// Tests that HasAnyError returns false when no results have exceptions.
    /// </summary>
    [Fact]
    public void ResultWithExceptionList_NoErrors_HasAnyErrorIsFalse()
    {
        var list = new ResultWithExceptionList<int>
        {
            new ResultWithException<int>(1),
            new ResultWithException<int>(2)
        };

        Assert.False(list.HasAnyError);
    }

    /// <summary>
    /// Tests that HasAnyError returns true when at least one result has an exception.
    /// </summary>
    [Fact]
    public void ResultWithExceptionList_WithError_HasAnyErrorIsTrue()
    {
        var list = new ResultWithExceptionList<int>
        {
            new ResultWithException<int>(1),
            new ResultWithException<int>("error")
        };

        Assert.True(list.HasAnyError);
    }

    /// <summary>
    /// Tests that HasException returns false for null exception message.
    /// </summary>
    [Fact]
    public void MayExcHelper_NullMessage_ReturnsFalse()
    {
        Assert.False(MayExcHelper.HasException(null));
    }

    /// <summary>
    /// Tests that HasException returns true for non-null exception message.
    /// </summary>
    [Fact]
    public void MayExcHelper_NonNullMessage_ReturnsTrue()
    {
        Assert.True(MayExcHelper.HasException("error"));
    }

    /// <summary>
    /// Tests that OutRef stores two values correctly.
    /// </summary>
    [Fact]
    public void OutRef_StoresTwoValues()
    {
        var outRef = new OutRef<string, int>("text", 42);

        Assert.Equal("text", outRef.Item1);
        Assert.Equal(42, outRef.Item2);
    }

    /// <summary>
    /// Tests that OutRef3 stores three values correctly.
    /// </summary>
    [Fact]
    public void OutRef3_StoresThreeValues()
    {
        var outRef = new OutRef3<string, int, bool>("text", 42, true);

        Assert.Equal("text", outRef.Item1);
        Assert.Equal(42, outRef.Item2);
        Assert.True(outRef.Item3);
    }

    /// <summary>
    /// Tests that OutRef4 stores four values correctly.
    /// </summary>
    [Fact]
    public void OutRef4_StoresFourValues()
    {
        var outRef = new OutRef4<string, int, bool, double>("text", 42, true, 3.14);

        Assert.Equal("text", outRef.Item1);
        Assert.Equal(42, outRef.Item2);
        Assert.True(outRef.Item3);
        Assert.Equal(3.14, outRef.Item4);
    }
}
