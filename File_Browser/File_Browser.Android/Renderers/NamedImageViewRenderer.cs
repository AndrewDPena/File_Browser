using System.ComponentModel;
using Xamarin.Forms.Platform.Android;

namespace File_Browser.Android.Renderers
{
    public class NamedImageViewRenderer : ImageRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}