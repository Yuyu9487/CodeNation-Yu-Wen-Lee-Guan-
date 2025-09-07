using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;

namespace CPrograming1
{
    public class Wave
    {
        private float phase = 0f;
        private SKSurface surface = null;
        public int width = 100;
        public int height = 100;

        public Wave()
        {
            SKImageInfo imageInfo = new SKImageInfo(width, height);
            surface = SKSurface.Create(imageInfo);
        }

        public void updateImage()
        {
            updatePhase(0.5f);
            try
            {
                SKCanvas canvas = surface.Canvas;

                canvas.Clear();

                using (SKPaint paint = new SKPaint())
                {
                    var path = new SKPath();
                    paint.Color = SKColors.Blue;
                    paint.StrokeWidth = 15;
                    paint.Style = SKPaintStyle.Stroke;
                    paint.IsAntialias = true;

                    float amplitude = 1f; // 波幅
                    float centerY = height * 0.1f;

                    path.MoveTo(0, centerY);
                    for (int x = 0; x <= width; x++)
                    {
                        float y = centerY + amplitude * (float)Math.Sin((x / (float)width * Math.PI * 2) + phase);
                        path.LineTo(x, y);
                    }
                    path.LineTo(width, height);
                    path.LineTo(0, height);
                    path.Close();

                    canvas.DrawPath(path, paint);
                    paint.Style = SKPaintStyle.Fill;
                    canvas.DrawRect(0, centerY, width, height, paint);
                }
            } catch (Exception ex) {}
        }

        public SKSurface getSurface() { return surface; }

        public Bitmap getBitmap ()
        {
            SKImage image = surface.Snapshot();
            SKData data = image.Encode(SKEncodedImageFormat.Png, 100);
            MemoryStream mStream = new MemoryStream(data.ToArray());
            return new Bitmap(mStream, false);
        }

        public SKBitmap getColorCoverBitmap(Color color, float height)
        {
            if (this.surface == null) return null;
            
            SKBitmap sKBitmap = SKBitmap.FromImage(this.surface.Snapshot());
            SKImageInfo info = new SKImageInfo(sKBitmap.Width, (int)(sKBitmap.Height * height), sKBitmap.ColorType, sKBitmap.AlphaType);

            SKBitmap outputBitmap = new SKBitmap(info);

            using (var canvas = new SKCanvas(outputBitmap))
            using (var paint = new SKPaint())
            {
                paint.IsAntialias = true;
                paint.ColorFilter = SKColorFilter.CreateColorMatrix(new float[]
                {
                    0,0,0,0,color.R,
                    0,0,0,0,color.G,
                    0,0,0,0,color.B,
                    0,0,0,1,0,
                });
                canvas.DrawBitmap(sKBitmap, new SKPoint(), paint);
            }

            return outputBitmap;

            //using (SKImage image = SKImage.FromBitmap(outputBitmap))
            //using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
            //using (MemoryStream mStream = new MemoryStream(data.ToArray()))
            //{
            //    return new Bitmap(mStream, false);
            //}
        }

        public void updatePhase(float delta)
        {
            phase += delta;
        }
    }
}
