using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TiempoExamen
{
    class ConvertidorImagenes : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tiempo = "";
            switch (value)
            {
                case "sol":
                    tiempo=  "assets/sunny.png";
                    break;
                case "nubes":
                    tiempo = "assets/cloudy.png";
                    break;
                case "lluvia":
                    tiempo = "assets/rain.png";
                    break;
                case "nieve":
                    tiempo = "assets/snow.png";
                    break;

                default:
                    break;
            }
            return tiempo;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
