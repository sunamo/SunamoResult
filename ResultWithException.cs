namespace SunamoResult;
public class ResultWithException<T>
{
    public T? Data { get; set; }
    /// <summary>
    ///     only string, because Message property isn't editable after instatiate
    ///     Usage: FubuCsprojFile
    /// </summary>
    public string? Exc { get; set; }
    public ResultWithException(T data)
    {
        Data = data;
    }
    public ResultWithException(string exc)
    {
        this.Exc = exc;
    }
    public ResultWithException(Exception exc)
    {
        this.Exc = exc.Message;
    }
    /// <summary>
    /// Pro případ že data josu string což je typ i exception
    /// </summary>
    public ResultWithException()
    {
    }
}