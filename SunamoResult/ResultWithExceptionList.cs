namespace SunamoResult;

public class ResultWithExceptionList<T> : List<ResultWithException<T>>
{
    public bool HasAnyError => this.Any(result => result.ExceptionMessage is not null);
}
