namespace SunamoResult;

public class ResultWithExceptionList<T> : List<ResultWithException<T>>
{
    /// <summary>
    /// Všechny chyby se musí logovat přesně tam kde vznikly
    /// Tohle už slouží jen abych věděl že data jsou nekompletní. 
    /// </summary>
    public bool WasSomeError { get => this.Any(d => d.Exc != null); }
}