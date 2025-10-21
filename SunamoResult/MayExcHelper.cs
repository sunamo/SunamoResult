// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoResult;
public class MayExcHelper
{
    public static bool MayExc(string exc)
    {
        if (exc != null)
        {
            Console.WriteLine(exc);
            //ThisApp.Error( result.exc);
            return true;
        }

        return false;
    }
}