using System;
using UIKit;
using XamlDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using XamlDemo.Include;

[assembly: ExportRenderer(typeof(HorizontalListview), typeof(HorizontalListviewRendererIos))]
 
namespace XamlDemo.iOS.Renderers
{
    public class HorizontalListviewRendererIos : ScrollViewRenderer
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
            this.ShowsHorizontalScrollIndicator = false;
            this.ShowsVerticalScrollIndicator = false;
            this.AlwaysBounceHorizontal = false;
            this.AlwaysBounceVertical = false;
            this.Bounces = false;

        }
    }
}
