using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace MySuperLeakyApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();

            // Ensure UseLeakDetection is called after logging has been configured!
            builder.UseLeakDetection(collectionTarget =>
            {
                // This callback will run any time a leak is detected.
                //Application.Current?.MainPage?.DisplayAlert("💦Leak Detected💦",
                //    $"❗🧟❗{collectionTarget.Name} is a zombie!", "OK");

                //Debug.WriteLine($"Holly mother of god, another leak!!! --> {collectionTarget.Name}");
            });
#endif
            return builder.Build();
        }
    }
}
