namespace SunamoResult;

/// <summary>
/// Wraps a result value or an exception message, enabling async-compatible error handling without ref/out parameters.
/// </summary>
/// <typeparam name="T">The type of the result data.</typeparam>
public class ResultWithException<T>
{
    /// <summary>
    /// Gets or sets the result data.
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Gets or sets the exception message as string, because the Message property of Exception is not editable after instantiation.
    /// </summary>
    public string? ExceptionMessage { get; set; }

    /// <summary>
    /// Initializes a new instance with the specified result data.
    /// </summary>
    /// <param name="data">The result data to store.</param>
    public ResultWithException(T data)
    {
        Data = data;
    }

    /// <summary>
    /// Initializes a new instance with the specified exception message.
    /// </summary>
    /// <param name="exceptionMessage">The exception message string.</param>
    public ResultWithException(string exceptionMessage)
    {
        ExceptionMessage = exceptionMessage;
    }

    /// <summary>
    /// Initializes a new instance with the message extracted from the specified exception.
    /// </summary>
    /// <param name="exception">The exception whose message will be stored.</param>
    public ResultWithException(Exception exception)
    {
        ExceptionMessage = exception.Message;
    }

    /// <summary>
    /// Initializes a new empty instance, used when the data type is string and could be confused with an exception message.
    /// </summary>
    public ResultWithException()
    {
    }
}
