using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamlDemo.Droid.Renderers;

[assembly: ExportRenderer(typeof(XamlDemo.CustomControls.HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]

namespace XamlDemo.Droid.Renderers
{
    public class HorizontalScrollViewRenderer : ScrollViewRenderer
    {
        public HorizontalScrollViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as CustomControls.HorizontalScrollView;
            element?.Render();
        }
    }
}