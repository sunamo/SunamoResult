namespace SunamoResult;

/// <summary>
/// Holds three values as an alternative to ref/out parameters for async methods.
/// </summary>
/// <typeparam name="T">The type of the first value.</typeparam>
/// <typeparam name="U">The type of the second value.</typeparam>
/// <typeparam name="V">The type of the third value.</typeparam>
public class OutRef3<T, U, V> : OutRef<T, U>
{
    /// <summary>
    /// Initializes a new instance with three values.
    /// </summary>
    /// <param name="value1">The first value.</param>
    /// <param name="value2">The second value.</param>
    /// <param name="value3">The third value.</param>
    public OutRef3(T value1, U value2, V value3) : base(value1, value2)
    {
        Item3 = value3;
    }

    /// <summary>
    /// Gets or sets the third value.
    /// </summary>
    public V Item3 { get; set; }
}
