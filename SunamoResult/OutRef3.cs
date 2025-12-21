namespace SunamoResult;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
public class OutRef3<T, U, V> : OutRef<T, U>
{
    public OutRef3(T t, U u, V v) : base(t, u)
    {
        Item3 = v;
    }
    public V Item3 { get; set; }
}