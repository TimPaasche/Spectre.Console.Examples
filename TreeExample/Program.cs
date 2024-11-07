namespace Spectre.Console.Examples.TreeExample;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create the tree
        var root = new Tree("Root");

        // Add some nodes
        var foo = root.AddNode("[yellow]Foo[/]");
        var table = foo.AddNode(new Table()
            .RoundedBorder()
            .AddColumn("First")
            .AddColumn("Second")
            .AddRow("1", "2")
            .AddRow("3", "4")
            .AddRow("5", "6"));

        table.AddNode("[blue]Baz[/]");
        foo.AddNode("Qux");

        var bar = root.AddNode("[yellow]Bar[/]");
        bar.AddNode(new Calendar(2020, 12)
            .AddCalendarEvent(2020, 12, 12)
            .HideHeader());

        root.AddNode("Label").Collapse();

        // Render the tree
        AnsiConsole.Write(root);

        var root2 = new Tree("Root")
            .Style("white on red");

        // ASCII guide lines
        root2 = new Tree("Root")
            .Guide(TreeGuide.Ascii);

        // Default guide lines
        root2 = new Tree("Root")
            .Guide(TreeGuide.Line);

        // Double guide lines
        root2 = new Tree("Root")
            .Guide(TreeGuide.DoubleLine);

        // Bold guide lines
        root2 = new Tree("Root")
            .Guide(TreeGuide.BoldLine);

        // Render the tree
        AnsiConsole.Write(root2);

    }
}