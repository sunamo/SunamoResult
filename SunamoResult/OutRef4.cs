namespace SunamoResult;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
public class OutRef4<T, U, V, W> : OutRef3<T, U, V>
{
    public OutRef4(T t, U u, V v, W w) : base(t, u, v)
    {
        Item4 = w;
    }

    public W Item4 { get; set; }
}