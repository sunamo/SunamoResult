namespace SunamoResult;

/// <summary>
/// Represents the result with exception t type.
/// </summary>
public class ResultWithException<T>
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Gets or sets the exception message.
    /// </summary>
    public string? ExceptionMessage { get; set; }

    /// <summary>
    /// Result with exception.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The result with exception result.</returns>
    public ResultWithException(T data)
    {
        Data = data;
    }

    /// <summary>
    /// Initializes a new instance of the result with exception class.
    /// </summary>
    /// <param name="data">The data.</param>
    public ResultWithException(string exceptionMessage)
    {
        ExceptionMessage = exceptionMessage;
    }

    /// <summary>
    /// Initializes a new instance of the result with exception class.
    /// </summary>
    /// <param name="exceptionMessage">The exception message.</param>
    public ResultWithException(Exception exception)
    {
        ExceptionMessage = exception.Message;
    }

    /// <summary>
    /// Initializes a new instance of the result with exception class.
    /// </summary>
    /// <param name="exception">The exception.</param>
    public ResultWithException()
    {
    }
}
