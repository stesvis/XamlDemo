using Android.Graphics;
using Android.Widget;

namespace XamlDemo.Droid.Utilities
{
    internal static class FontAwesomeUtility
    {
        public static void CheckAndSetTypeFace(TextView view)
        {
            if (view.Text.Length == 0)
            {
                return;
            }

            var text = view.Text;

            //// If you enable these lines
            //if (text.Length > 1 || text[0] < 0xf000)
            //{
            //    return;
            //}

            var context = MainActivity.Instance;
            var font = Typeface.CreateFromAsset(context.ApplicationContext.Assets, "fontawesome.ttf");
            view.Typeface = font;
        }
    }
}