using Xamarin.Forms;

namespace File_Browser.Views
{
    public class NamedImageView : Image
    {
        public string Name
        {
            get => (string)GetValue(NameProperty); 
            set => SetValue(NameProperty, value);
        }
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(NamedImageView),default(string), propertyChanged: PropertyChanged );

        private static void PropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            throw new System.NotImplementedException();
        }
    }
}