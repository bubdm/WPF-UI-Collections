using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace _02_WPFTreeView
{
    /// <summary>
    /// Converts a full path to a specific image type of a drive, folder or file
    /// </summary>
    [ValueConversion(typeof(string), typeof(BitmapImage))]

    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the full path
            var path = (string)value;
            // If the path is null, ignore it
            if (path == null)
                return null;

            // Get the name of file/folder
            var name = MainWindow.GetFileFolderName(path);

            // By default, we preassume an image
            var image = "Image/file.png";


            return new BitmapImage(new Uri($"pack://application:,,,/Images/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
