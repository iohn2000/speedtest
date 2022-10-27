namespace SpeedTest;

using Spectre.Console;

public class SpeedTestRunner
{
    public void StartTest()
    {
        AnsiConsole.Markup("working on speed");
        AnsiConsole.Status()
        .Start("Doing some work...",a=>
            {
                a.Spinner(Spinner.Known.Dots12);
                AnsiConsole.MarkupLine("Doing some work...");
                Thread.Sleep(1000);
            });

        System.Console.WriteLine("I'm running");
    }
}