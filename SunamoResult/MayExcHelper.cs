namespace SunamoResult;

public class MayExcHelper
{
    public static bool HasException(string? exceptionMessage)
    {
        if (exceptionMessage is not null)
        {
            Console.WriteLine(exceptionMessage);
            return true;
        }

        return false;
    }
}
