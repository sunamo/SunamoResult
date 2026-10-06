namespace SunamoResult;

public class ResultWithException<T>
{
    public T? Data { get; set; }

    public string? ExceptionMessage { get; set; }

    public ResultWithException(T data)
    {
        Data = data;
    }

    public ResultWithException(string exceptionMessage)
    {
        ExceptionMessage = exceptionMessage;
    }

    public ResultWithException(Exception exception)
    {
        ExceptionMessage = exception.Message;
    }

    public ResultWithException()
    {
    }
}
