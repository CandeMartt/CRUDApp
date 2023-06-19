using CRUDApp.Views;

namespace CRUDApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AddUpdateStudentDetail), typeof(AddUpdateStudentDetail));
	}
}
