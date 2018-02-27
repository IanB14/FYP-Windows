using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
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
    public sealed partial class drugList : Page
    {

        public class Drug
        {
            public string drugName { get; set; }
            public int drugID { get; set; }
        }

        private List<Drug> listOfDrugs = new List<Drug>();


        public drugList()
        {
            this.InitializeComponent();

            listOfDrugs.Add(new Drug { drugName = "Lexapro (Escitalopram)", drugID = 97 });
            listOfDrugs.Add(new Drug { drugName = "Diazemuls (Diazepam)", drugID = 95});
            listOfDrugs.Add(new Drug { drugName = "Xanax (Alprazolam)", drugID = 99});


            drugTestList.ItemsSource = listOfDrugs;
        }

        private void drugTestList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Selection Changed");
        }

        
    }
}
