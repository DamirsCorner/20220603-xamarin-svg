using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Svg;

namespace XamarinFormsSvg.Converters
{
    public class UrlToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                var uriString = (string)value;
                Uri uri = new Uri(uriString);
                if (uri.AbsolutePath.ToLowerInvariant().EndsWith(".svg"))
                {
                    return SvgImageSource.FromSvgUri(uriString, 200, 200, default(Color));
                }
                else
                {
                    return ImageSource.FromUri(uri);
                }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
