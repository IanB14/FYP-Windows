using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI;

namespace App5
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            // This line doesn't work - it won't collapse the back button
            // SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

            // Code to trigger the hover event for button 1. Commented out for now
            //button1.PointerEntered += Button1_PointerEntered;
            //button1.PointerExited += Button1_PointerExited;

        }

        /* this code IS working, but it's getting stuck behind the other, default button hover behaviour. Needs to be fixed before
           launch
        
        private void Button1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            var borderColor = new SolidColorBrush(Color.FromArgb(255, 128, 205, 61));
            var borderThickness = new Thickness(1);
            button1.BorderBrush = borderColor;
            button1.BorderThickness = borderThickness;
            button1.Background = borderColor;
        }

        private void Button1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            var borderReturnColor = new SolidColorBrush(Color.FromArgb(0, 10, 10, 10));
            button1.BorderBrush = borderReturnColor;
        }
        */


        private void prescriptionButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(prescriptionsPage), new DrillInNavigationTransitionInfo());
            
        }

        private void drugsListButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(drugList), new DrillInNavigationTransitionInfo());
        }

        private void qrCodeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qrCode), new DrillInNavigationTransitionInfo());
        }

        private void pharmaciesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pharmacies), new DrillInNavigationTransitionInfo());
        }

        private void doctorsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(doctors), new DrillInNavigationTransitionInfo());
        }


        private void accountButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(account), new DrillInNavigationTransitionInfo());
        }

        private async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog aboutPopup = new ContentDialog()
            {
                Title = "About",
                Content = "2017 - 2018. Developed by Ian Burke.",
                PrimaryButtonText = "Dismiss"
            };

            await aboutPopup.ShowAsync();
        }

        private async void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            ContentDialog logOutPopup = new ContentDialog()
            {
                Title = "Log Out",
                Content = "Are you sure you want to log out?",
                PrimaryButtonText = "Log Out",
                SecondaryButtonText = "Dismiss"
            };

            ContentDialogResult result = await logOutPopup.ShowAsync();
            if(result == ContentDialogResult.Primary)
            {
                this.Frame.Navigate(typeof(loginPage), new DrillInNavigationTransitionInfo());
            }
        }

        private async void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            ContentDialog contactPopup = new ContentDialog()
            {
                Title = "Contact",
                Content = "Contact ian_burke@hotmail.com for bug reports and feature requests",
                PrimaryButtonText = "Dismiss"
            };

            await contactPopup.ShowAsync();
        }

    }
}