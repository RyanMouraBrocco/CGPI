using AtividadeCGPI.ImageProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI
{
    public partial class FormImageProcessing : Form
    {
        private Bitmap originalImage;
        public FormImageProcessing()
        {
            InitializeComponent();
            originalImage = null;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pbImage.Image = originalImage;
                    ImageProcessor processor = new ImageProcessor(originalImage);
                }
                catch
                {
                    MessageBox.Show("Imagem inválida", "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                ImageProcessor processor = new ImageProcessor(originalImage);
                pbImage.Image = processor.CreateGrayScaleImage();

            }
        }

        private void btnBlackWhite_Click(object sender, EventArgs e)
        {
            ImageProcessor processor = new ImageProcessor(originalImage);
            pbImage.Image = processor.CreateBlackWhiteImage();

        }

        private void FormImageProcessing_Load(object sender, EventArgs e)
        {
        }

        private void UpdateHistogram(Dictionary<Color, int> histogram)
        {
            dgHistogram.Rows.Clear();
            int rowIndex = 0;
            foreach (var item in histogram)
            {
                dgHistogram.Rows.Add();
                dgHistogram.Rows[rowIndex].Cells[0].Value = item.Key.IsNamedColor ? item.Key.Name : $"({item.Key.R}, {item.Key.G}, {item.Key.B})";
                dgHistogram.Rows[rowIndex].Cells[1].Value = item.Value;
                rowIndex += 1;
            }
        }

        private void btnUpdateHistogram_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                ImageProcessor processor = new ImageProcessor((Bitmap)pbImage.Image);
                UpdateHistogram(processor.CreateHistogram());
            }
        }

        private void btnSepiaTone_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                ImageProcessor processor = new ImageProcessor(originalImage);
                pbImage.Image = processor.ApplyFilter(ImageFilterType.SepiaTone);
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                ImageProcessor processor = new ImageProcessor(originalImage);
                pbImage.Image = processor.ApplyFilter(ImageFilterType.Negative);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                pbImage.Image = originalImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageConverter converter = new ImageConverter();
                byte[] imageBytes = (byte[])converter.ConvertTo(pbImage.Image, typeof(byte[]));
                File.WriteAllBytes(saveFileDialog.FileName, imageBytes);
            }
        }
    }
}
