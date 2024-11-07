namespace Spectre.Console.Examples.PanelExample;

internal class Program
{
    private static void Main(string[] args)
    {
        var panel = new Panel("Hello World");

        // Sets the header
        panel.Header = new PanelHeader("Some text");

        // Sets the border
        panel.Border = BoxBorder.None;
        panel.Border = BoxBorder.Rounded;
        panel.Border = BoxBorder.Heavy;
        panel.Border = BoxBorder.Ascii;
        panel.Border = BoxBorder.Double;
        panel.Border = BoxBorder.Square;

        // Sets the padding
        panel.Padding = new Padding(2, 2, 2, 2);

        // Sets the expand property
        panel.Expand = true;

        AnsiConsole.Write(panel);
    }
}