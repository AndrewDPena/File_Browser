using System.ComponentModel;
using Android.Views;
using Android.Widget;
using File_Browser.Android.Renderers;
using File_Browser.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly:ExportRenderer(typeof(NamedImageView), typeof(NamedImageViewRenderer))]
namespace File_Browser.Android.Renderers
{
    public class NamedImageViewRenderer : ViewRenderer<NamedImageView, View>
    {
        protected override View CreateNativeControl()
        {
            return LayoutInflater.From(Context).Inflate(Resource.Layout.NamedImageView, null);
        }

        private ImageView _imageView;
        private TextView _textView;
        private TextView _dateLastEdited;
        private TextView _fileSize;
        protected override void OnElementChanged(ElementChangedEventArgs<NamedImageView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var control = CreateNativeControl();
                _imageView = control.FindViewById<ImageView>(Resource.Id.image_view);
                _textView = control.FindViewById<TextView>(Resource.Id.text_view);
                _dateLastEdited = control.FindViewById<TextView>(Resource.Id.date_last_edited);
                _fileSize = control.FindViewById<TextView>(Resource.Id.file_size);
                SetNativeControl(control);
            }

            if (e.NewElement != null)
            {
                SetImage(e.NewElement);
                SetText(e.NewElement);
                SetDate(e.NewElement);
                SetSize(e.NewElement);
            }
        }

        private void SetImage(NamedImageView e)
        {
            _imageView.SetImageResource(e.IsDirectory ? Resource.Drawable.icfolder : Resource.Drawable.icfile);
        }

        private void SetText(NamedImageView e)
        {
            _textView.Text = e.Name;
        }

        private void SetDate(NamedImageView e)
        {
            _dateLastEdited.Text = e.Date;
        }
        
        private void SetSize(NamedImageView e)
        {
            _fileSize.Text = e.Size;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            switch (e.PropertyName)
            {
                case nameof(NamedImageView.Name): SetText(Element);
                    break;
                case nameof(NamedImageView.IsDirectory): SetImage(Element);
                    break;
            }
        }
    }
}