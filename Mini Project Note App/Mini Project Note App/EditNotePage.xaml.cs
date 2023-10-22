namespace Mini_Project_Note_App;

public partial class EditNotePage : ContentPage
{
	public EditNotePage()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e) 
		=> await Navigation.PopAsync();

    private void Delete_Clicked(object sender, EventArgs e) { }
}