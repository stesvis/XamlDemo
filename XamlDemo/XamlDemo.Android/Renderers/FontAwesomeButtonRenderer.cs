using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamlDemo.Droid.Utilities;
using XamlDemo.Droid.Renderers;

[assembly: ExportRenderer(typeof(Button), typeof(FontAwesomeButtonRenderer))]

namespace XamlDemo.Droid.Renderers
{
    public class FontAwesomeButtonRenderer : ButtonRenderer
    {
        public FontAwesomeButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            FontAwesomeUtility.CheckAndSetTypeFace(Control);
        }
    }
}