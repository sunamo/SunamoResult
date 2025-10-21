// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoResult;
public class OutRef<T, U>(T t, U u)
{
    public T Item1 { get; set; } = t;
    public U Item2 { get; set; } = u;
}