using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class account : Page
    {
        public class navigationItems
        {
            public SymbolIcon headericon { get; set; }
            public string title { get; set; }
        }

        private List<navigationItems> listOfSettings = new List<navigationItems>();


        public account()
        {
            this.InitializeComponent();

            listOfSettings.Add(new navigationItems { title = "Personal Information" });
            listOfSettings.Add(new navigationItems { title = "Contact Preferences" });
            listOfSettings.Add(new navigationItems { title = "Security Settings" });
            listOfSettings.Add(new navigationItems { title = "Privacy Settings" });

            navigationLinks.ItemsSource = listOfSettings;
        }


        private void navigationLinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Selection Changed");

            switch (navigationLinks.SelectedIndex)
            {
                case 0:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Visible;
                    contactInformationPanel.Visibility = Visibility.Collapsed;
                    securitySettingsPanel.Visibility = Visibility.Collapsed;
                    privacySettingsPanel.Visibility = Visibility.Collapsed;
                    break;

                case 1:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Collapsed;
                    contactInformationPanel.Visibility = Visibility.Visible;
                    securitySettingsPanel.Visibility = Visibility.Collapsed;
                    privacySettingsPanel.Visibility = Visibility.Collapsed;
                    break;

                case 2:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Collapsed;
                    contactInformationPanel.Visibility = Visibility.Collapsed;
                    securitySettingsPanel.Visibility = Visibility.Visible;
                    privacySettingsPanel.Visibility = Visibility.Collapsed;
                    break;

                case 3:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Collapsed;
                    contactInformationPanel.Visibility = Visibility.Collapsed;
                    securitySettingsPanel.Visibility = Visibility.Collapsed;
                    privacySettingsPanel.Visibility = Visibility.Visible;
                    break;

                case 4:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Collapsed;
                    contactInformationPanel.Visibility = Visibility.Collapsed;
                    securitySettingsPanel.Visibility = Visibility.Collapsed;
                    privacySettingsPanel.Visibility = Visibility.Collapsed;
                    break;

                default:

                    defaultView.Visibility = Visibility.Collapsed;
                    defaultViewIcons.Visibility = Visibility.Collapsed;

                    personalInformationPanel.Visibility = Visibility.Collapsed;
                    contactInformationPanel.Visibility = Visibility.Collapsed;
                    securitySettingsPanel.Visibility = Visibility.Collapsed;
                    privacySettingsPanel.Visibility = Visibility.Collapsed;
                    break;
            }


        }

        private void resetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(forgotPasswordPage), new DrillInNavigationTransitionInfo());
        }
    }
}
