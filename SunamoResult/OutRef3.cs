namespace SunamoResult;

public class OutRef3<T, U, V> : OutRef<T, U>
{
    public OutRef3(T value1, U value2, V value3) : base(value1, value2)
    {
        Item3 = value3;
    }

    public V Item3 { get; set; }
}
