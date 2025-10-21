// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoResult;
public class ResultWithException<T>
{
    public T? Data { get; set; }
    /// <summary>
    ///     only string, because Message property isn't editable after instatiate
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
    /// In case the data is a string which is also an exception type
    /// </summary>
    public ResultWithException()
    {
    }
}