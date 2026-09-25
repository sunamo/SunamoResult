namespace SunamoResult;

public class OutRef<T, U>(T value1, U value2)
{
    public T Item1 { get; set; } = value1;

    public U Item2 { get; set; } = value2;
}
