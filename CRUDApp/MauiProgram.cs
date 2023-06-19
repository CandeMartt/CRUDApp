using CRUDApp.Services;
using CRUDApp.ViewModels;
using CRUDApp.Views;

namespace CRUDApp;

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

        //Services
        builder.Services.AddSingleton<IStudentService, StudentService>();

        //Views registration
        builder.Services.AddSingleton<StudentListPage>();
        builder.Services.AddTransient<AddUpdateStudentDetail>();

        //Views Model
        builder.Services.AddSingleton<StudentListPageViewModel>();
        builder.Services.AddTransient<AddUpdateStudentDetailViewModel>();

        return builder.Build();
	}
}
