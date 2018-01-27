using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            public string Name { get; set; }
            public int ID { get; set; }
            public string Dosage { get; set; }
            public string Length { get; set; }
            public bool Pickup { get; set; }
            public string Instructions { get; set; }
        }

        private List<Prescription> listOfPrescriptions = new List<Prescription>();

        public prescriptionsPage()
        {
            this.InitializeComponent();

            listOfPrescriptions.Add(new Prescription { Name = "Lexapro (Escitalopram)", ID = 97, Dosage = "10mg", Length = "2-4 weeks", Pickup = true, Instructions = "Take one daily" });
            listOfPrescriptions.Add(new Prescription { Name = "Diazemuls (Diazepam)", ID = 95, Dosage = "5mg", Length = "2 months", Pickup = false, Instructions = "Take two every four hours" });
            listOfPrescriptions.Add(new Prescription { Name = "Xanax (Alprazolam)", ID = 99, Dosage = "0.5mg", Length = "3 weeks", Pickup = true, Instructions = "Take two once a day" });

            testList.ItemsSource = listOfPrescriptions;
        }
      
    }
}