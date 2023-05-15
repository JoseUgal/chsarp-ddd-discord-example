using System.Globalization;

namespace Discord.Shared.Domain;

public static class Utils
{
    public static string DateToString(DateTime date) 
        => date.ToString("s", CultureInfo.CurrentCulture);

}