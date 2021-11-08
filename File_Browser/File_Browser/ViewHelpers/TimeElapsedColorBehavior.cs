using System;
using Xamarin.Forms;

namespace File_Browser.ViewHelpers
{
    public static class TimeElapsedColorBehavior
    {
        public static readonly BindableProperty TimeElapsedProperty = BindableProperty.CreateAttached("TimeElapsed", 
            typeof(DateTime), typeof(TimeElapsedColorBehavior),default(DateTime), propertyChanged: PropertyChanged );

        public static DateTime GetTimeElapsed(BindableObject bindable)
        {
            return (DateTime)bindable.GetValue(TimeElapsedProperty);
        }

        public static void SetTimeElapsed(BindableObject bindable, DateTime dateTime)
        {
            bindable.SetValue(TimeElapsedProperty, dateTime);
        }
        private static void PropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (!(bindable is View view)) return;
            
            if (newvalue is DateTime dateTime)
            {
                var span = DateTime.Now - dateTime;
                if (span.TotalSeconds < 60)
                {
                    view.BackgroundColor = Color.Chartreuse;
                    return;
                }

                if (span.TotalHours < 1)
                {
                    view.BackgroundColor = Color.Goldenrod;
                    return;
                }

                if (span.TotalHours < 24)
                {
                    view.BackgroundColor = Color.DodgerBlue;
                    return;
                }

                if (span.TotalDays < 7)
                {
                    view.BackgroundColor = Color.SaddleBrown;
                    return;
                }

                view.BackgroundColor = Color.Tomato;
            }
        }
    }
}