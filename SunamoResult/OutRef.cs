namespace SunamoResult;

/// <summary>
/// Out ref.
/// </summary>
/// <param name="value1">The value 1.</param>
/// <param name="value2">The value 2.</param>
/// <returns>The out ref result.</returns>
public class OutRef<T, U>(T value1, U value2)
{
    /// <summary>
    /// Gets or sets the item 1.
    /// </summary>
    public T Item1 { get; set; } = value1;

    /// <summary>
    /// Gets or sets the item 2.
    /// </summary>
    public U Item2 { get; set; } = value2;
}
