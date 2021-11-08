using System.Linq;
using Android.Graphics;
using Android.Widget;
using File_Browser.Android.Renderers;
using File_Browser.ViewHelpers;
using File_Browser.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportEffect(typeof(ImageTintEffectRenderer), nameof(ImageTintEffect))]
[assembly:ResolutionGroupName("Demo")]
namespace File_Browser.Android.Renderers
{
    public class ImageTintEffectRenderer : PlatformEffect
    {
        protected override void OnAttached()
        {
            var effect = (ImageTintEffect)Element.Effects.FirstOrDefault(e => e is ImageTintEffect);
            if (Control is ImageView image)
            {
                var filter = new PorterDuffColorFilter(effect.TintColor.ToAndroid(), PorterDuff.Mode.SrcIn);
                image.SetColorFilter(filter);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}