using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToASCIIConverter
{
    class Converter
    {
        private readonly string[] _asciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
        private readonly string _path;

        public static string Content { get; set; }

        public Converter(string path)
        {
            _path = path;
        }
        
        public string ConvertToAscii(int asciiWidth)
        {
            Bitmap image = new Bitmap(_path, true);
            image = GetReSizedImage(image, asciiWidth);
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    //Высислить среднюю величину rgb-компонентов, чтобы найти серый 
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);

                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(_asciiChars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }

        private Bitmap GetReSizedImage(Bitmap image, int asciiWidth)
        {
            int asciiHeight = 0;
            //Рассчитать новое значение высоты изображения 
            asciiHeight = (int)Math.Ceiling((double)image.Height * asciiWidth / image.Width);

            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image) result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return result;
        }
    }
}
