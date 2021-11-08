using Xamarin.Forms;

namespace File_Browser.Views
{
    public class NamedImageView : View
    {
        public string Name
        {
            get => (string)GetValue(NameProperty); 
            set => SetValue(NameProperty, value);
        }

        public string Date
        {
            get => (string)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }
        
        public string Size
        {
            get => (string)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }

        public bool IsDirectory
        {
            get => (bool)GetValue(IsDirectoryProperty); 
            set => SetValue(IsDirectoryProperty, value);
        }
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(NamedImageView),default(string));
        
        public static readonly BindableProperty DateProperty = BindableProperty.Create(nameof(Date), typeof(string), typeof(NamedImageView),default(string));
        
        public static readonly BindableProperty SizeProperty = BindableProperty.Create(nameof(Size), typeof(string), typeof(NamedImageView),default(string));

        public static readonly BindableProperty IsDirectoryProperty = BindableProperty.Create(nameof(IsDirectory), typeof(bool), typeof(NamedImageView),default(bool));
    }
}