using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetRecognizer
{
    public static class ImageProcessor
    {
        public static bool[,] GetColoredPixels(this Bitmap bmp)
        {
            //bmp.Save("sha.jpg", ImageFormat.Jpeg);
            bool[,] pixels = new bool[bmp.Width, bmp.Height];
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    if (bmp.GetPixel(i, j).Name == "ff000000")
                        pixels[i, j] = true;
            return pixels;
                    
        }



        internal static int GetColoredPixelsCount(bool[,] coloredPixels)
        {
            int count = 0;
            for (int i = 0; i < coloredPixels.GetLength(0); i++)
                for (int j = 0; j < coloredPixels.GetLength(1); j++)
                    if (coloredPixels[i, j])
                        count++;
            return count;
        }

        internal static Bitmap FromArray(int[,] alphabet)
        {
            Bitmap bmp = new Bitmap(AlphabetProcessor.AlphabetSize, AlphabetProcessor.AlphabetSize);
            for (int i = 0; i < alphabet.GetLength(0); i++)
                for (int j = 0; j < alphabet.GetLength(1); j++)
                    if (alphabet[i, j] > 0)
                        Graphics.FromImage(bmp).DrawRectangle(new Pen(Color.Black), i, j, 1, 1);
            bmp.Save(String.Format("hoora.jpg", ImageFormat.Jpeg));
            return bmp;
        }
    }
}
