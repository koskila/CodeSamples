using System;
using System.Globalization;

public class CultureInfoEnumeration
{

    public static void Main()
    {
        var sampleDate = new DateTime(2021, 12, 31, 13, 05, 40);

        // Displays properties & an example date time for all installed cultures
        Console.WriteLine("<table><tr><th>CULTURE</th><th>ISO</th><th>ISO</th><th>WIN</th><th>DISPLAYNAME</th><th>Date/time format sample</th><th>ENGLISHNAME</th></tr>");
        foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
        {
            Console.Write($"<tr><td>{ci.Name}</td>");
            Console.Write($"<td>{ci.TwoLetterISOLanguageName}</td>");
            Console.Write($"<td>{ci.ThreeLetterISOLanguageName}</td>");
            Console.Write($"<td>{ci.ThreeLetterWindowsLanguageName}</td>");
            Console.Write($"<td>{ci.DisplayName}</td>");
            Console.WriteLine($"<td>{sampleDate.ToString(ci.DateTimeFormat)}</td>");
            Console.WriteLine($"<td>{ci.EnglishName}</td></tr></table>");

        }

        Console.ReadKey();
    }
}