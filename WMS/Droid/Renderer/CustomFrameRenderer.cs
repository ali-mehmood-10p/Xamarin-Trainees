using Android.Graphics;
using WMS;
using WMS.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace WMS.Droid
{
    public class CustomFrameRenderer : FrameRenderer
    {
        Frame _frame;
		public override void Draw(Canvas canvas)
		{
			base.Draw(canvas);
            _frame = this.Element;
			DrawOutline(canvas, canvas.Width, canvas.Height);
		}

		void DrawOutline(Canvas canvas, int width, int height)
		{
			using (var paint = new Paint { AntiAlias = true })
			using (var path = new Path())
			using (Path.Direction direction = Path.Direction.Cw)
			using (Paint.Style style = Paint.Style.Stroke)
			using (var rect = new RectF(0, 0, width, height))
			{
                float rx = Forms.Context.ToPixels(_frame.CornerRadius);
				float ry = Forms.Context.ToPixels(_frame.CornerRadius);
				path.AddRoundRect(rect, rx, ry, direction);

				paint.StrokeWidth = 2f;  //set outline stroke
				paint.SetStyle(style);
                paint.Color = _frame.OutlineColor.ToAndroid(); // Android.Graphics.Color.Gray; 
				canvas.DrawPath(path, paint);
			}
		}
	}
}
