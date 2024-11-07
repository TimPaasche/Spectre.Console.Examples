namespace Spectre.Console.Examples.SectionExample;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Confirmation
        // Ask the user to confirm
        var confirmation = AnsiConsole.Prompt(
            new TextPrompt<bool>("Run prompt example?")
                .AddChoice(true)
                .AddChoice(false)
                .DefaultValue(true)
                .WithConverter(choice => choice ? "y" : "n"));

        // Echo the confirmation back to the terminal
        Console.WriteLine(confirmation ? "Confirmed" : "Declined");

        // -----[ OR ]-----

        // Ask the user to confirm
        var confirmation2 = AnsiConsole.Prompt(
            new ConfirmationPrompt("Run prompt example?"));

        // Echo the confirmation back to the terminal
        Console.WriteLine(confirmation2 ? "Confirmed" : "Declined");
        #endregion Confirmation

        #region Simple Questions
        // Ask the user a couple of simple questions
        var name = AnsiConsole.Prompt(
            new TextPrompt<string>("What's your name?"));
        var age = AnsiConsole.Prompt(
            new TextPrompt<int>("What's your age?"));

        // Echo the name and age back to the terminal
        AnsiConsole.WriteLine($"So you're {name} and you're {age} years old");

        // -----[ OR ]-----

        // Ask the user a couple of simple questions
        var name2 = AnsiConsole.Ask<string>("What's your name?");
        var age2 = AnsiConsole.Ask<int>("What's your age?");

        // Echo the name and age back to the terminal
        AnsiConsole.WriteLine($"So you're {name2} and you're {age2} years old");
        #endregion Simple Questions

        #region Choices
        // Ask for the user's favorite fruit
        var fruit = AnsiConsole.Prompt(
            new TextPrompt<string>("What's your favorite fruit?")
              .AddChoices(["Apple", "Banana", "Orange"])
              .DefaultValue("Orange"));

        // Echo the fruit back to the terminal
        Console.WriteLine($"I agree. {fruit} is tasty!");
        #endregion Choices

        #region Validation
        // Ask the user to guess the secret number
        var number = AnsiConsole.Prompt(
            new TextPrompt<int>("What's the secret number?")
              .Validate((n) => n switch
              {
                  < 50 => ValidationResult.Error("Too low"),
                  50 => ValidationResult.Success(),
                  > 50 => ValidationResult.Error("Too high"),
              }));

        // Echo the user's success back to the terminal
        Console.WriteLine($"Correct! The secret number is {number}.");
        #endregion Validation

        #region Secret
        // Ask the user to enter the password
        var password = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter password:")
                .Secret());

        // Echo the password back to the terminal
        Console.WriteLine($"Your password is {password}");
        #endregion Secret

        #region Optinal
        // Ask the user to enter the password
        var color = AnsiConsole.Prompt(
            new TextPrompt<string>("[[Optional]] Favorite color?")
                .AllowEmpty());

        // Echo the color back to the terminal
        Console.WriteLine(string.IsNullOrWhiteSpace(color)
            ? "You're right, all colors are beautiful"
            : $"I agree. {color} is a very beautiful color");
        #endregion Optinal
    }
}