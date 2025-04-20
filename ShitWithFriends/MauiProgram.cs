using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ShitWithFriends;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterPageAndViewModel()
			.RegisterServices()
			.RegisterRoutes();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	private static MauiAppBuilder RegisterPageAndViewModel(this MauiAppBuilder builder)
	{
		return builder;
	}
    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        return builder;
    }

    private static MauiAppBuilder RegisterRoutes(this MauiAppBuilder builder)
    {
        return builder;
    }
}
