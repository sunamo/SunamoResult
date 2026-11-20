namespace SunamoResult;

/// <summary>
/// Represents the out ref 4 t u v w type.
/// </summary>
public class OutRef4<T, U, V, W> : OutRef3<T, U, V>
{
    /// <summary>
    /// Initializes a new instance of the out ref 4 class.
    /// </summary>
    /// <param name="value1">The value 1.</param>
    /// <param name="value2">The value 2.</param>
    /// <param name="value3">The value 3.</param>
    /// <param name="value4">The value 4.</param>
    public OutRef4(T value1, U value2, V value3, W value4) : base(value1, value2, value3)
    {
        Item4 = value4;
    }

    /// <summary>
    /// Gets or sets the item 4.
    /// </summary>
    public W Item4 { get; set; }
}
