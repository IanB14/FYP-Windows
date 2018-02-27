using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI;
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
    public sealed partial class prescriptionsPage : Page
    {

        public class Prescription
        {
            public string icon { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
            public string Dosage { get; set; }
            public string Length { get; set; }
            public string Pickup { get; set; }
            public string Instructions { get; set; }
        }

        private List<Prescription> listOfPrescriptions = new List<Prescription>();

        public prescriptionsPage()
        {
            this.InitializeComponent();

            listOfPrescriptions.Add(new Prescription { icon = "/Resources/prescriptionItems/lexaproL.png", Name = "Lexapro (Escitalopram)", ID = 97, Dosage = "10mg", Length = "2-4 weeks", Pickup = "Ready for Pickup", Instructions = "Take one daily" });
            listOfPrescriptions.Add(new Prescription { icon = "/Resources/prescriptionItems/diazemulsD.png", Name = "Diazemuls (Diazepam)", ID = 95, Dosage = "5mg", Length = "2 months", Pickup = "Picked Up", Instructions = "Take two every four hours" });
            listOfPrescriptions.Add(new Prescription { icon = "/Resources/prescriptionItems/xanaxX.png", Name = "Xanax (Alprazolam)", ID = 99, Dosage = "0.5mg", Length = "3 weeks", Pickup = "Pickup Overdue", Instructions = "Take two once a day" });

            testList.ItemsSource = listOfPrescriptions;

            testList.SelectionChanged += ListView_SelectionChanged;
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("X was selected", e);
        }

        private void activeHyperLink_Click(object sender, RoutedEventArgs e)
        {
            stackPanel1.Visibility = Visibility.Visible;
            inactiveTextBlock.Visibility = Visibility.Collapsed;
            CompletedTextBlock.Visibility = Visibility.Collapsed;
        }


        private void inactiveHyperLink_Click(object sender, RoutedEventArgs e)
        {
            stackPanel1.Visibility = Visibility.Collapsed;
            inactiveTextBlock.Visibility = Visibility.Visible;
            CompletedTextBlock.Visibility = Visibility.Collapsed;
        }

        private void completedHyperLink_Click(object sender, RoutedEventArgs e)
        {
            stackPanel1.Visibility = Visibility.Collapsed;
            inactiveTextBlock.Visibility = Visibility.Collapsed;
            CompletedTextBlock.Visibility = Visibility.Visible;
        }


    }
}