namespace SunamoResult;

/// <summary>
/// Represents the may exc helper type.
/// </summary>
public class MayExcHelper
{
    /// <summary>
    /// Has exception.
    /// </summary>
    /// <param name="exceptionMessage">The exception message.</param>
    /// <returns>The has exception result.</returns>
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
