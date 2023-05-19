﻿namespace AppDalleE;

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
                fonts.AddFont("Ubuntu-MediumItalic.ttf", "UbuntuMediumItalic");
                fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
            });

		return builder.Build();
	}
}
