namespace SunamoResult;

/// <summary>
/// Holds four values as an alternative to ref/out parameters for async methods.
/// </summary>
/// <typeparam name="T">The type of the first value.</typeparam>
/// <typeparam name="U">The type of the second value.</typeparam>
/// <typeparam name="V">The type of the third value.</typeparam>
/// <typeparam name="W">The type of the fourth value.</typeparam>
public class OutRef4<T, U, V, W> : OutRef3<T, U, V>
{
    /// <summary>
    /// Initializes a new instance with four values.
    /// </summary>
    /// <param name="value1">The first value.</param>
    /// <param name="value2">The second value.</param>
    /// <param name="value3">The third value.</param>
    /// <param name="value4">The fourth value.</param>
    public OutRef4(T value1, U value2, V value3, W value4) : base(value1, value2, value3)
    {
        Item4 = value4;
    }

    /// <summary>
    /// Gets or sets the fourth value.
    /// </summary>
    public W Item4 { get; set; }
}
