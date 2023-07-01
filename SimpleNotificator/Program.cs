using Microsoft.Toolkit.Uwp.Notifications;
using Zx;

if (ToastNotificationManagerCompat.WasCurrentProcessToastActivated())
{
    var tcs = new CancellationTokenSource();
    ToastNotificationManagerCompat.OnActivated += async e =>
    {
        Console.WriteLine($"start {e.Argument}");
        await $"start {e.Argument}";
        tcs.Cancel();
    };
    while (!tcs.IsCancellationRequested){ }
}

ConsoleApp.Run<SimpleNotificator.SimpleNotificator>(args);