using System.Linq;
using Xamarin.Forms;

namespace File_Browser.ViewHelpers
{
    public class ImageTintEffect : RoutingEffect
    {
        public Color TintColor { get; set; }
        
        public ImageTintEffect():base($"Demo.{nameof(ImageTintEffect)}"){}
        
        public static readonly BindableProperty TintColorProperty = BindableProperty.CreateAttached(nameof(TintColor), typeof(Color), typeof(ImageTintEffect),default(Color), propertyChanged: PropertyChanged );

        public static Color GetTintColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(TintColorProperty);
        }

        public static void SetTintColor(BindableObject bindable, Color color)
        {
            bindable.SetValue(TintColorProperty, color);
        }
        private static void PropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (!(bindable is View view)) return;
            var color = (Color)newvalue;
            var effect = (ImageTintEffect)view.Effects.FirstOrDefault(e => e is ImageTintEffect);
            if (effect != null)
            {
                view.Effects.Remove(effect);
            }

            if (color != default)
            {
                effect = new ImageTintEffect();
                effect.TintColor = color;
                view.Effects.Add(effect);
            }
        }
    }
}