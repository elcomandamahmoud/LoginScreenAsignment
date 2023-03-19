namespace LoginScreenAsignment;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void LogOutButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}