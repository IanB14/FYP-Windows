using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace App5.Converters
{
    class pickupConverterClass: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string Pickup = (value as string);
            if (Pickup == "Ready for Pickup") return new SolidColorBrush(Color.FromArgb(255, 61, 132, 220));
            else if (Pickup == "Picked Up") return new SolidColorBrush(Color.FromArgb(255, 128, 220, 61));
            else if (Pickup == "Pickup Overdue") return new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));

            // default case
            return new SolidColorBrush(Color.FromArgb(255, 61, 132, 220));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}