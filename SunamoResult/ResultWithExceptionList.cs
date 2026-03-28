namespace SunamoResult;

/// <summary>
/// Collection of <see cref="ResultWithException{T}"/> results, providing aggregate error checking.
/// </summary>
/// <typeparam name="T">The type of the result data in each element.</typeparam>
public class ResultWithExceptionList<T> : List<ResultWithException<T>>
{
    /// <summary>
    /// Gets a value indicating whether any result in the collection has an exception.
    /// All errors must be logged exactly where they occur; this property only indicates that data is incomplete.
    /// </summary>
    public bool HasAnyError { get => this.Any(result => result.ExceptionMessage != null); }
}
