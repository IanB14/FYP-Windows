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
using Windows.UI;

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


            switch (drugTestList.SelectedIndex)
            {
                case 0:
                    placeholders.Visibility = Visibility.Collapsed;
                    detail.Visibility = Visibility.Visible;
                    drugName.Text = "Lexapro (Escitalopram)";
                    drugManufacturerText.Text = "Forest Laboratories";
                    drugIndicationsText.Text = "Major depressive episodes, panic disorder (with/without agoraphobia)";
                    drugDosageText.Text = "Adult: 5mg daily for 1 week, then 10mg daily\tChild: Not recommended";
                    drugDirectionsText.Text = "As recommended by your doctor";
                    drugSideEffectsText.Text = "None";
                    drugSpecialPrecautionsText.Text = "Do not take to treat depression or psychotic illness";
                    Interaction1.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));
                    Interaction1.Text = "MAOIs";
                    Interaction2.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 214, 61));
                    Interaction2.Text = "Serotonergics";
                    Interaction3.Text = "";
                    break;

                case 1:
                    placeholders.Visibility = Visibility.Collapsed;
                    detail.Visibility = Visibility.Visible;
                    drugName.Text = "Diazemuls (Diazepam)";
                    drugManufacturerText.Text = "Actavis";
                    drugIndicationsText.Text = "Severe anxiety/agitation; Acute muscle spasm";
                    drugDosageText.Text = "Adults: Slow I/V injection, 1mL/min\tChild: 0.2mL/Kg I/V or I/M";
                    drugDirectionsText.Text = "As directed by your doctor";
                    drugSideEffectsText.Text = "Drowsiness";
                    drugSpecialPrecautionsText.Text = "Do not take to treat depression or psychotic illness";
                    Interaction1.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));
                    Interaction1.Text = "Alcohol";
                    Interaction2.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 214, 61));
                    Interaction2.Text = "Clozapine";
                    Interaction3.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 214, 61));
                    Interaction3.Text = "Levodopa";
                    break;

                case 2:
                    placeholders.Visibility = Visibility.Collapsed;
                    detail.Visibility = Visibility.Visible;
                    drugName.Text = "Xanax (Alprazolam)";
                    drugManufacturerText.Text = "Pfizer";
                    drugIndicationsText.Text = "Severe anxiety, causing extreme distress";
                    drugDosageText.Text = "0.5-1mg, 3-4 times daily in divided doses\tChild: Not recommended";
                    drugDirectionsText.Text = "As directed by your doctor";
                    drugSideEffectsText.Text = "None";
                    drugSpecialPrecautionsText.Text = "May cause confusional state or irratibility";
                    Interaction1.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));
                    Interaction1.Text = "Alcohol";
                    Interaction2.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));
                    Interaction2.Text = "Cletoconazole";
                    Interaction3.Foreground = new SolidColorBrush(Color.FromArgb(255, 220, 214, 61));
                    Interaction3.Text = "Fluvoxamine";
                    break;

                default:
                    detail.Visibility = Visibility.Collapsed;
                    placeholders.Visibility = Visibility.Visible;
                    break;

            }

            if (drugTestList.SelectedIndex == 1)
            {
                
            }
        }

        
    }
}
