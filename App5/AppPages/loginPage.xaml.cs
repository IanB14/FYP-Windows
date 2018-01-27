using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class loginPage : Page
    {
        public loginPage()
        {
            this.InitializeComponent();
        }

        string enteredUsername;

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            enteredUsername = username.Text;
        }


        string enteredPassword;

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            enteredPassword = password.Password;
        }

        /* Code to handle pressing enter on the password textbox. Screws up the login event handler so it's commented out for now
         * 
         * This code needs to be added to the .xaml password box to work: KeyDown="resetPasswordButton_KeyDown"
         * 
         * private void resetPasswordButton_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Key.Return) { 
            
            }
        }
        */


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (enteredUsername == "IanB14" && enteredPassword == "password") {
                Debug.WriteLine("Username and Password matched");
                Frame.Navigate(typeof(MainPage), new DrillInNavigationTransitionInfo());
            }else
            {
                Debug.WriteLine("Error - Incorrect Username or Password");
                wrongCredentialsTextBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }

        private void resetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(forgotPasswordPage), new DrillInNavigationTransitionInfo());
        }

        private void createAccountButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(createAccountPage), new DrillInNavigationTransitionInfo());
        }
    }
}