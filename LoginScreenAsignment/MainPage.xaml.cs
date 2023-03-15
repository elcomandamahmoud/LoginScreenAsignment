namespace LoginScreenAsignment;
public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(UserNameBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            DisplayAlert("Alert","You have loged on successfuly ","ok");
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (ShowPasswordCheckBox.IsChecked)
            PasswordBox.IsPassword = false;
        else
            PasswordBox.IsPassword = true;
    }
}
