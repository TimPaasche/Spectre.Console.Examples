
using Spectre.Console;
using Spectre.Console.Json;

namespace SpectreConsoleTestWorkspace.RenderingJsonExample;

internal class Program
{
    private static void Main(string[] args)
    {
        var json = new JsonText(
            """
            { 
                "hello": 32, 
                "world": { 
                    "foo": 21, 
                    "bar": 255,
                    "baz": [
                        0.32, 0.33e-32,
                        0.42e32, 0.55e+32,
                        {
                            "hello": "world",
                            "lol": null
                        }
                    ]
                } 
            }
            """);

        AnsiConsole.Write(
            new Panel(json)
                .Header("Some JSON in a panel")
                .Collapse()
                .RoundedBorder()
                .BorderColor(Color.Yellow));

        string json2 =
            """
            { 
                "hello": 32, 
                "world": { 
                    "foo": 21, 
                    "bar": 255,
                    "baz": [
                        0.32, 0.33e-32,
                        0.42e32, 0.55e+32,
                        {
                            "hello": "world",
                            "lol": null
                        }
                    ]
                } 
            }
            """;

        AnsiConsole.Write(
            new JsonText(json2)
                .BracesColor(Color.Red)
                .BracketColor(Color.Green)
                .ColonColor(Color.Blue)
                .CommaColor(Color.Red)
                .StringColor(Color.Green)
                .NumberColor(Color.Blue)
                .BooleanColor(Color.Red)
                .NullColor(Color.Green));
    }
}