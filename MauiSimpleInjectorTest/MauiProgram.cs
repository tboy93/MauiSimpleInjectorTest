using SimpleInjector;

namespace MauiSimpleInjectorTest;

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


        var container = new Container();

        builder.Services
            .AddSimpleInjector(container)
            .BuildServiceProvider(validateScopes: true)
            .UseSimpleInjector(container);

        container.Register<ISampleService, SampleService>(Lifestyle.Singleton);

        container.Verify();

        return builder.Build();
    }
}
