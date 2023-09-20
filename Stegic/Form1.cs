using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Stegic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Stegic";
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openFileDialog.InitialDirectory = @"D:\TestIMG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(imagePath).ToLower();

                if (fileExtension == ".jpg")
                {
                    // If a .jpg image is selected, convert it to .png
                    string pngImagePath = ConvertToPng(imagePath);

                    if (!string.IsNullOrEmpty(pngImagePath))
                    {
                        imagePath = pngImagePath;
                    }
                }

                PathTextbox.Text = imagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
                pictureBox1.ImageLocation = imagePath;
            }
        }
        
        private string ConvertToPng(string jpgImagePath)
        {
            try
            {
                using (Bitmap jpgImage = new Bitmap(jpgImagePath))
                {
                    string pngImagePath = Path.ChangeExtension(jpgImagePath, "png");
                    jpgImage.Save(pngImagePath, ImageFormat.Png);
                    return pngImagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image conversion error:" + ex.Message);
                return null;
            }
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            string imagePath = PathTextbox.Text;

            if (File.Exists(imagePath))
            {
                Bitmap img = new Bitmap(imagePath);
                
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);

                        if (i < 1 && j < SecretMessageTextbox.TextLength)
                        {
                            Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                            Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                            Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                            char letter = Convert.ToChar(SecretMessageTextbox.Text.Substring(j, 1));
                            int value = Convert.ToInt32(letter);
                            Console.WriteLine("letter : " + letter + " value : " + value);

                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));

                        }

                        if (i == img.Width - 1 && j == img.Height - 1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, SecretMessageTextbox.TextLength));
                        }

                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Image Files(*.png)|*.png|Все файлы (*.*)|*.*";
                    saveFileDialog.Title = "Select a location to save the message image";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Save the image with the embedded message to the selected file
                        img.Save(saveFileDialog.FileName);

                        // Freeing up resources
                        img.Dispose();

                        // Notification of message embedding completion
                        MessageBox.Show(
                            "The message has been successfully implemented and saved in a file "
                            + saveFileDialog.FileName);
                    }
                }
            }
        }


        private void DecodeButton_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(PathTextbox.Text);
            string message = String.Empty;

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLenght = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLenght)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            SecretMessageTextbox.Text = message;
        }
    }
}