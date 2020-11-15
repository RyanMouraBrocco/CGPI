using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace AtividadeCGPI.ImageProcessing
{
    public class ImageProcessor
    {
        public Bitmap Image { get; private set; }

        public ImageProcessor(string filePath)
        {
            try
            {
                Image = new Bitmap(filePath);
            }
            catch
            {
                throw new Exception("Invalid image");
            }
        }

        public ImageProcessor(Bitmap image)
        {
            if (image != null)
            {
                Image = image;
            }
            else
            {
                throw new Exception("Image is not be null");
            }
        }

        public Bitmap CreateGrayScaleImage()
        {
            Bitmap grayScaleImage = new Bitmap(Image.Width, Image.Height);

            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
               });

            SetMatrixInBitmap(grayScaleImage, colorMatrix);

            return grayScaleImage;
        }

        public Bitmap CreateBlackWhiteImage()
        {
            Bitmap blackWhiteImage = new Bitmap(Image.Width, Image.Height);

            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {

                    Color color = Image.GetPixel(i, j);
                    int average = ((color.R + color.B + color.G) / 3);

                    if (average < 60)
                        blackWhiteImage.SetPixel(i, j, Color.Black);
                    else
                        blackWhiteImage.SetPixel(i, j, Color.White);

                }
            }

            return blackWhiteImage;
        }

        public Bitmap ApplyFilter(ImageFilterType type)
        {
            Bitmap filteredImage = new Bitmap(Image.Width, Image.Height);
            switch (type)
            {
                case ImageFilterType.SepiaTone:
                    SetSepiaToneFilter(filteredImage);
                    break;
                case ImageFilterType.Negative:
                    SetNegativeFilter(filteredImage);
                    break;
                default:
                    break;
            }
            return filteredImage;
        }

        private void SetSepiaToneFilter(Bitmap image)
        {
            ColorMatrix colorMatrix = new ColorMatrix(
            new float[][]
            {
                new float[]{.393f, .349f, .272f, 0, 0},
                new float[]{.769f, .686f, .534f, 0, 0},
                new float[]{.189f, .168f, .131f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}
            });
            SetMatrixInBitmap(image, colorMatrix);
        }

        private void SetNegativeFilter(Bitmap image)
        {
            ColorMatrix colorMatrix = new ColorMatrix(
            new float[][]
            {
                new float[]{-1, 0, 0, 0, 0},
                new float[]{0, -1, 0, 0, 0},
                new float[]{0, 0, -1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{1, 1, 1, 1, 1}
            });
            SetMatrixInBitmap(image, colorMatrix);
        }

        private void SetMatrixInBitmap(Bitmap image, ColorMatrix matrix)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix);
                    graphics.DrawImage(Image, new Rectangle(0, 0, Image.Width, Image.Height), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
        }

        public Dictionary<Color, int> CreateHistogram()
        {
            Dictionary<Color, int> histogram = new Dictionary<Color, int>();
            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    Color color = Image.GetPixel(i, j);

                    if (histogram.ContainsKey(color))
                    {

                        histogram[color] = histogram[color] + 1;
                    }
                    else
                    {
                        histogram.Add(color, 1);
                    }
                }
            }

            return histogram;
        }
    }
}
