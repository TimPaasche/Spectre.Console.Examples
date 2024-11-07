namespace Spectre.Console.Examples.ColumnsExample;

internal class Program
{
    private static void Main(string[] args)
    {
        // Render two items on separate columns to Console
        AnsiConsole.Write(new Columns(
                    new Text("Item 1"),
                    new Text("Item 2")
                ));


        // Create a list of Items
        var columns = new List<Text>(){
            new Text("Item 1"),
            new Text("Item 2"),
            new Text("Item 3")
        };

        // Render each item in list on separate line
        AnsiConsole.Write(new Columns(columns));

        // Create a list of Items, apply separate styles to each
        var columns2 = new List<Text>(){
            new Text("Item 1", new Style(Color.Red, Color.Black)),
            new Text("Item 2", new Style(Color.Green, Color.Black)),
            new Text("Item 3", new Style(Color.Blue, Color.Black))
        };

        // Renders each item with own style
        AnsiConsole.Write(new Columns(columns2));
    }
}