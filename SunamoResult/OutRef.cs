namespace SunamoResult;

/// <summary>
/// Holds two values as an alternative to ref/out parameters for async methods.
/// </summary>
/// <typeparam name="T">The type of the first value.</typeparam>
/// <typeparam name="U">The type of the second value.</typeparam>
/// <param name="value1">The first value.</param>
/// <param name="value2">The second value.</param>
public class OutRef<T, U>(T value1, U value2)
{
    /// <summary>
    /// Gets or sets the first value.
    /// </summary>
    public T Item1 { get; set; } = value1;

    /// <summary>
    /// Gets or sets the second value.
    /// </summary>
    public U Item2 { get; set; } = value2;
}
