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
    class nameConverterClass : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string Name = (value as string);
            if (Name == "Lexapro (Escitalopram)") return new SolidColorBrush(Color.FromArgb(255, 61, 132, 220));
            else if (Name == "Diazemuls (Diazepam)") return new SolidColorBrush(Color.FromArgb(255, 128, 220, 61));
            else if (Name == "Xanax (Alprazolam)") return new SolidColorBrush(Color.FromArgb(255, 220, 83, 61));

            // default case
            return new SolidColorBrush(Color.FromArgb(255, 61, 132, 220));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
