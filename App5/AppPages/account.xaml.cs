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
    public sealed partial class account : Page
    {
        public account()
        {
            this.InitializeComponent();
        }

        public class navigationItems
        {
            public string title { get; set; }
            public Symbol Symbol { get; set; }
        }

        private ObservableCollection<navigationItems> _navItems = new ObservableCollection<navigationItems>()
        {
            new navigationItems() { title = "navItem1", Symbol=Windows.UI.Xaml.Controls.Symbol.People },
            new navigationItems() { title = "navItem2", Symbol=Windows.UI.Xaml.Controls.Symbol.Phone },
        };

        public ObservableCollection<navigationItems> navItems
        {
            get { return _navItems; }

        }

        private void navigationLinks_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
