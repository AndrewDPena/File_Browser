using System;
using System.Globalization;
using Xamarin.Forms;

namespace File_Browser.ViewHelpers
{
    public class FileSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long fileSize)
            {
                var temp = (double)fileSize;
                if (fileSize > 1000000000)
                {
                    return $"{temp/1000000000:0.##} GB";
                } 
                
                if (fileSize > 1000000)
                {
                    return $"{temp / 1000000:0.##} MB";
                }
                
                if (fileSize > 1000)
                {
                    return $"{temp/1000:0.##} KB";
                }

                return fileSize + "B";
            }

            return value;        
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}