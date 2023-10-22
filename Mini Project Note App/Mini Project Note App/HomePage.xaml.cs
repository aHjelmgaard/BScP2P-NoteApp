namespace Mini_Project_Note_App;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

        var items = new List<string>
            {
                "Eggs",
                "Noodz",
                "Carrots"
            };

        // Set the ItemsSource of the ListView
        itemListView.ItemsSource = items;

    }

    private void Uni_Clicked(object sender, EventArgs e) { }

    private void Todo_Clicked(object sender, EventArgs e) { }

    private void All_Clicked(object sender, EventArgs e) { }

    private async void OnTapped(object sender, EventArgs e) 
        => await Navigation.PushAsync(new EditNotePage());
    
    private async void OnNewNoteTapped(object sender, EventArgs e) 
        => await Navigation.PushAsync(new NewNotePage());
}