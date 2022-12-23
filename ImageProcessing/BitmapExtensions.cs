using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_PROGLAN.ImageProcessing
{
    public static class BitmapExtensions
    {
        public static double[,] CreateMatrix(this Bitmap image, float threshold)
        {
            var _matrix = new double[image.Width, image.Height];
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var brightness = image.GetPixel(x, y).GetBrightness();
                    _matrix[x, y] = (brightness < threshold) ? 0.0 : 1.0;
                }
            }
            return _matrix;
        }
    }
}
