using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace App5
{
    public sealed partial class forgotPasswordPage : Page
    {
        public forgotPasswordPage()
        {
            this.InitializeComponent();
        }


        String enteredEmail;

        private void resetEmailEntered(object sender, RoutedEventArgs e)
        {
            enteredEmail = emailForPasswordResetTextBox.Text;
            Debug.Write("E-mail address entered: ", enteredEmail);
        }

        private async void sendResetEmailButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxAndButton.Visibility = Visibility.Collapsed;
            SuccessTextBlock.Text = ("The password reset e-mail was sent to " + enteredEmail);

            spinner.Visibility = Visibility.Visible;

            // Wait 3 seconds after clicking the login button
            await Task.Delay(TimeSpan.FromSeconds(3));

            spinner.Visibility = Visibility.Collapsed;
            emailSent.Visibility = Visibility.Visible;
        }
    }
}