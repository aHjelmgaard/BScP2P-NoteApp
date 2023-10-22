namespace Mini_Project_Note_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new AppShell());
	}
}
