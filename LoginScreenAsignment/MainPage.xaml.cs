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
        {
            DisplayAlert("Alert", "You have loged on successfully ", "ok");
            Navigation.PushModalAsync(new SecondPage());
        }
        else
        {
            DisplayAlert("Erorr", "Login failed", "Ok");
            UserNameBox.Focus();
        }
    }

    private void ShowPasswordCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (ShowPasswordCheckBox.IsChecked)
            PasswordBox.IsPassword = false;
        else
            PasswordBox.IsPassword = true;
    }

    private void ForgetPasswordButton_Clicked(object sender, EventArgs e)
    {
        if (ForgetPasswordButton.Text == "Have you forgottten your password?")
        {
            ForgetPasswordButton.Text = "Change password";
            PasswordBox.Text = "";
            PasswordBox.Placeholder = "Please enter a new password";
            PasswordBox.Focus();
        }
        if (string.IsNullOrEmpty(PasswordBox.Text) && ForgetPasswordButton.Text == "Change password")
        {
            DisplayAlert("Erorr", "You couldn't let password box is empty while trying to change your password", "Ok");
            PasswordBox.Focus();
        }
        else
        {
            PasswordBox.Text = "";
            PasswordBox.Placeholder = "Please enter your password";
            ForgetPasswordButton.Text = "Have you forgottten your password?";
            DisplayAlert("Congratulation!", "You have changed your password successfully", "Ok");
            UserNameBox.Focus();
        }
    }
}
