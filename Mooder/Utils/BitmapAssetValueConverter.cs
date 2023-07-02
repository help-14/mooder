using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using System;
using System.Globalization;

namespace Mooder.Utils
{
    public class BitmapAssetValueConverter : IValueConverter
    {
        public static BitmapAssetValueConverter Instance = new BitmapAssetValueConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is string rawUri && targetType.IsAssignableFrom(typeof(Bitmap)))
            {
                //Uri uri;

                // Allow for assembly overrides
                //if (rawUri.StartsWith("avares://"))
                //{
                //    uri = new Uri(rawUri);
                //}
                //else
                //{
                //    string assemblyName = Assembly.GetEntryAssembly().GetName().Name;
                //    uri = new Uri($"avares://{assemblyName}/{rawUri}");
                //}

                return new Bitmap(rawUri);
            }

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
