using System;
using System.Globalization;
using Xamarin.Forms;

namespace File_Browser.ViewHelpers
{
    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                var span = DateTime.Now - dateTime;
                if (span.TotalSeconds < 60)
                {
                    return "A few seconds ago";
                }

                if (span.TotalHours < 1)
                {
                    return "Within the past hour";
                }

                if (span.TotalHours < 24)
                {
                    return "Today";
                }

                if (span.TotalDays < 7)
                {
                    return "This week";
                }

                return dateTime.ToLongDateString();
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}