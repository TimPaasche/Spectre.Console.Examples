﻿namespace Spectre.Console.Examples.SectionExample;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ask for the user's favorite fruits
        var fruits = AnsiConsole.Prompt(
            new MultiSelectionPrompt<string>()
                .Title("What are your [green]favorite fruits[/]?")
                .NotRequired() // Not required to have a favorite fruit
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .InstructionsText(
                    "[grey](Press [blue]<space>[/] to toggle a fruit, " +
                    "[green]<enter>[/] to accept)[/]")
                .AddChoices(new[] {
            "Apple", "Apricot", "Avocado",
            "Banana", "Blackcurrant", "Blueberry",
            "Cherry", "Cloudberry", "Coconut",
                }));

        // Write the selected fruits to the terminal
        foreach (string fruit in fruits)
        {
            AnsiConsole.WriteLine(fruit);
        }

    }
}