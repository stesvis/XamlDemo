using System;
using System.ComponentModel;
using XamlDemo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamlDemo.Include;

[assembly: ExportRenderer(typeof(HorizontalListview), typeof(HorizontalListviewRendererAndroid))]
 
namespace XamlDemo.Droid.Renderers
{
    public class HorizontalListviewRendererAndroid : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as HorizontalListview;
            element?.Render();

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;

        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ChildCount > 0)
            {
                GetChildAt(0).HorizontalScrollBarEnabled = false;
                GetChildAt(0).VerticalScrollBarEnabled = false;

            }
        }
    }
}
