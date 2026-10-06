namespace SunamoResult;

public class OutRef4<T, U, V, W> : OutRef3<T, U, V>
{
    public OutRef4(T value1, U value2, V value3, W value4) : base(value1, value2, value3)
    {
        Item4 = value4;
    }

    public W Item4 { get; set; }
}
