namespace Spectre.Console.Examples.TableExample;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a table
        var table = new Table();

        // Add some columns
        table.AddColumn("Foo");
        table.AddColumn(new TableColumn("Bar").Centered());

        // Add some rows
        table.AddRow("Baz", "[green]Qux[/]");
        table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

        // Sets the border
        table.Border(TableBorder.None);
        table.Border(TableBorder.Ascii);
        table.Border(TableBorder.Square);
        table.Border(TableBorder.Rounded);

        // Table will take up as much space as it can
        // with respect to other things.
        table.Expand();

        // Table will take up minimal width
        table.Collapse();

        // Hides all column headers
        table.HideHeaders();

        // Sets the table width to 50 cells
        table.Width(50);

        table.Alignment(Justify.Right);
        table.RightAligned();
        table.Centered();
        table.LeftAligned();

        table.Columns[0].Alignment(Justify.Right);
        table.Columns[0].LeftAligned();
        table.Columns[0].Centered();
        table.Columns[0].RightAligned();

        // Set padding individually
        table.Columns[0].PadLeft(3);
        table.Columns[0].PadRight(5);

        // Or chained together
        table.Columns[0].PadLeft(3).PadRight(5);

        // Or with the shorthand method if the left and right 
        // padding are identical. Vertical padding is ignored.
        table.Columns[0].Padding(4, 0);

        // Disable column wrapping
        table.Columns[0].NoWrap();

        // Set the column width
        table.Columns[0].Width(15);

        // Render the table to the console
        AnsiConsole.Write(table);
    }
}