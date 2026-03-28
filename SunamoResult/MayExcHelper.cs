namespace SunamoResult;

/// <summary>
/// Helper class for checking and logging exception messages from <see cref="ResultWithException{T}"/>.
/// </summary>
public class MayExcHelper
{
    /// <summary>
    /// Checks if the exception message is non-null, logs it to console if present, and returns whether an exception occurred.
    /// </summary>
    /// <param name="exceptionMessage">The exception message to check.</param>
    /// <returns><c>true</c> if the exception message is non-null; otherwise, <c>false</c>.</returns>
    public static bool HasException(string? exceptionMessage)
    {
        if (exceptionMessage != null)
        {
            Console.WriteLine(exceptionMessage);
            return true;
        }

        return false;
    }
}
