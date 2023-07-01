using Microsoft.Toolkit.Uwp.Notifications;

namespace SimpleNotificator;

public class SimpleNotificator : ConsoleAppBase
{
    [RootCommand]
    public void Execute([Option("t")] string title, [Option("c")] string content, [Option("a")] string action)
    {
        new ToastContentBuilder()
            .SetToastScenario(ToastScenario.Reminder)
            .AddText(title)
            .AddText(content)
            .AddArgument(action)
            .AddAttributionText("Simple Notificator 🎆")
            .Show();
    }
}