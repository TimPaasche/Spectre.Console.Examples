using Spectre.Console;

namespace SpectreConsoleTestWorkspace.CalendarExample;

internal class Program
{
    private static void Main(string[] args)
    {
        var calendar = new Calendar(2020, 10);
        AnsiConsole.Write(calendar);

        // You can set the calendar's culture to show localized weekdays.
        calendar = new Calendar(2020, 10);
        calendar.Culture("de-DE");
        AnsiConsole.Write(calendar);

        // You can hide the calendar header.
        calendar = new Calendar(2020, 10);
        calendar.HideHeader();
        AnsiConsole.Write(calendar);

        // You can set the header style of the calendar.
        calendar = new Calendar(2020, 10);
        calendar.HeaderStyle(Style.Parse("blue bold"));
        AnsiConsole.Write(calendar);

        // You can add an event to the calendar.
        // If a date has an event associated with it, the date gets highlighted in the calendar.
        calendar = new Calendar(2020, 10);
        calendar.AddCalendarEvent(2020, 10, 11);
        AnsiConsole.Write(calendar);

        // You can set the highlight style for a calendar event via SetHighlightStyle.
        calendar = new Calendar(2020, 10);
        calendar.AddCalendarEvent(2020, 10, 11);
        calendar.HighlightStyle(Style.Parse("yellow bold"));
        AnsiConsole.Write(calendar);
    }
}