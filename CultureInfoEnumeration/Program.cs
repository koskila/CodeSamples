using System;
using System.Globalization;

public class CultureInfoEnumeration
{
    public static void Main()
    {
        var sampleDate = new DateTime(2021, 12, 31, 13, 05, 40);

        // Displays properties &
        // an example date time for all installed cultures
        Console.Write("<table><tr>");
        Console.Write("<th>CULTURE</th>");
        Console.Write("<th>ISO (2-letter)</th>");
        //Console.Write("<th>ISO (3-letter)</th>");
        //Console.Write("<th>WIN</th>");
        Console.Write("<th>Display name</th>");
        //Console.Write("<th>English name</th>");
        Console.Write("<th>Date/time format sample</th>");
        Console.WriteLine("</tr>");

        foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
            Console.Write($"<tr><td>{ci.Name}</td>");
            Console.Write($"<td>{ci.TwoLetterISOLanguageName}</td>");
            //Console.Write($"<td>{ci.ThreeLetterISOLanguageName}</td>");
            //Console.Write($"<td>{ci.ThreeLetterWindowsLanguageName}</td>");
            Console.Write($"<td>{ci.DisplayName}</td>");
            //Console.Write($"<td>{ci.EnglishName}</td>");
            Console.Write($"<td>{sampleDate.ToString(ci.DateTimeFormat)}</td>");
            Console.WriteLine("</tr>");
        }
        Console.WriteLine("</table>");

        Console.ReadKey();
    }
}