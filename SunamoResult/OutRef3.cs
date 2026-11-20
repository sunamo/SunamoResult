namespace SunamoResult;

/// <summary>
/// Represents the out ref 3 t u v type.
/// </summary>
public class OutRef3<T, U, V> : OutRef<T, U>
{
    /// <summary>
    /// Initializes a new instance of the out ref 3 class.
    /// </summary>
    /// <param name="value1">The value 1.</param>
    /// <param name="value2">The value 2.</param>
    /// <param name="value3">The value 3.</param>
    public OutRef3(T value1, U value2, V value3) : base(value1, value2)
    {
        Item3 = value3;
    }

    /// <summary>
    /// Gets or sets the item 3.
    /// </summary>
    public V Item3 { get; set; }
}
