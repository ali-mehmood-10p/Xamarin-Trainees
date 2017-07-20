using Android.Graphics;
using WMS;
using WMS.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransparentButton), typeof(TransparentButtonRenderer))]
namespace WMS.Droid
{
    public class TransparentButtonRenderer : ButtonRenderer
	{
        public override void Draw(Canvas canvas)
        {
            base.OnDraw(canvas);
        }
    }
}
