using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class createAccountPage : Page
    {
        public createAccountPage()
        {
            this.InitializeComponent();
        }

        // Strings to hold the values of the text boxes
        String firstName;
        String surname;
        String username;
        String password;
        String email;
        String phoneNo;
        String Address1;
        String Address2;
        String Address3;


        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstName = firstNameTextBox.Text;
        }

        private void surnameNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            surname = surnameNameTextBox.Text;
        }

        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            username = usernameTextBox.Text;
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            password = passwordTextBox.Password;
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            email = emailTextBox.Text;
        }

        private void phoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            phoneNo = phoneNumberTextBox.Text;
        }

        private void AddressL1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Address1 = AddressL1TextBox.Text;
        }

        private void AddressL2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Address2 = AddressL2TextBox.Text;
        }

        private void AddressL3TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Address3 = AddressL3TextBox.Text;
        }

        private async void createAccountButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.Write("The text fields entered were:\n" + firstName + "\n" + surname + "\n" + username + "\n"
                        + password + "\n" + email + "\n" + phoneNo + "\n" + Address1 + "\n" + Address2 + "\n"
                        + Address3 + "\n");

            textBoxesAndButton.Visibility = Visibility.Collapsed;
            Spinner.Visibility = Visibility.Visible;

            // Wait 3 seconds after clicking the login button
            await Task.Delay(TimeSpan.FromSeconds(3));

            Spinner.Visibility = Visibility.Collapsed;
            accountCreated.Visibility = Visibility.Visible;

            accountDetails.Text = "Account Name: " + firstName + " " + surname
                                  + "\nUsername: " + username
                                  + "\nE-mail Address: " + email;

        }
    }
}
