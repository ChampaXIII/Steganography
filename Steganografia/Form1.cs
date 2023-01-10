using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioBitLeastSignificant_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void buttonChoseImmage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogFile = new OpenFileDialog();
            dialogFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png| Text Files (.txt)|*.txt";

            if (dialogFile.ShowDialog() == DialogResult.OK)
            {
                if (dialogFile.FileName.EndsWith(".txt"))
                {
                    string text = System.IO.File.ReadAllText(dialogFile.FileName);
                    textBox.Text = text;
                }
                else
                {
                    pictureBox.Image = new Bitmap(dialogFile.FileName);
                } 
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PNG Image|*.png|BMP Image|*.bmp|GIF Image|*.gif";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                System.Drawing.Image image = pictureBox.Image;
                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (radioWrite.Checked)
            {
                if (radioBitLeastSignificant.Checked)
                {
                    incriptLessSignificant(textBox.Text, (Bitmap)pictureBox.Image);
                }
                else
                {
                    incriptMoreSignificant(textBox.Text, (Bitmap)pictureBox.Image);
                }
            }
            else
            {
                if (radioBitLeastSignificant.Checked)
                {
                    decriptLessSignificant((Bitmap)pictureBox.Image);
                }
                else
                {
                    decriptMoreSignificant((Bitmap)pictureBox.Image);
                }
            }
        }

        private void radioBitMostSignificant_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void incriptLessSignificant(string text, Bitmap image)
        {
            if(text.Length * 8 > image.Width * image.Height + 8)
            {
                MessageBox.Show("L'immagine è troppo piccola o il messaggio troppo lungo");
                return;
            }

            int charIndex = -1;
            int binaryIndex = -1;
            string charBinary = "";

            int x, y;

            int red;

            Color pixel;
            
            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    binaryIndex++;

                    pixel = image.GetPixel(x, y);
                    red = pixel.R - (pixel.R % 2);
                    

                    if (binaryIndex % 8 == 0)
                    {
                        binaryIndex = 0;
                        charIndex++;
                        charBinary = Convert.ToString((int)text[charIndex], 2).PadLeft(8, '0');
                    }
                     
                    //Modificando il numero
                    
                    red += charBinary[binaryIndex] - '0';

                    //MessageBox.Show("" + pixel.R, "Before");

                    image.SetPixel(x, y, Color.FromArgb(red , pixel.G, pixel.B));
                    //pixel = image.GetPixel(x, y);
                    //MessageBox.Show("" + pixel.R, "After");
                    

                    if (charIndex == text.Length - 1 && binaryIndex == 7)
                    {
                        lastCharacter(x, y, image, true);

                        pictureBox.Image = image;
                        textBox.Text = "";
                        MessageBox.Show("Ho finito di nascondere il messaggio", "Fine");
                        return;
                    }
                }
            }
        }

        private void incriptMoreSignificant(string text, Bitmap image)
        {
            if (text.Length * 8 > image.Width * image.Height - 8)
            {
                MessageBox.Show("L'immagine è troppo piccola o il messaggio troppo lungo");
                return;
            }

            int charIndex = -1;
            int binaryIndex = -1;
            string charBinary = "";

            int x, y;

            int red;

            Color pixel;

            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    binaryIndex++;

                    pixel = image.GetPixel(x, y);

                    if(pixel.R >= 128)
                    {
                        red = pixel.R - 128;
                    }
                    else
                    {
                        red = pixel.R;
                    }

                    if (binaryIndex % 8 == 0)
                    {
                        binaryIndex = 0;
                        charIndex++;
                        charBinary = Convert.ToString((int)text[charIndex], 2).PadLeft(8, '0');
                    }

                    //Modificando il numero

                    red += (charBinary[binaryIndex] - '0') * 128;

                    //MessageBox.Show("" + pixel.R, "Before");

                    image.SetPixel(x, y, Color.FromArgb(red, pixel.G, pixel.B));
                    //pixel = image.GetPixel(x, y);
                    //MessageBox.Show("" + pixel.R, "After");


                    if (charIndex == text.Length - 1 && binaryIndex == 7)
                    {
                        lastCharacter(x, y, image, false);

                        pictureBox.Image = image;
                        textBox.Text = "";
                        MessageBox.Show("Ho finito di nascondere il messaggio", "Fine");
                        return;
                    }
                }
            }
        }

        private void lastCharacter(int x, int y, Bitmap image, bool lessSignificant)
        {
            Color pixel;
            int red;

            string lastCharacter = "00011000";
            int lastCharacterIndex = 0;

            for (y++;  y < image.Height; y++)
            {
                for (x++; x < image.Width; x++)
                {
                    pixel = image.GetPixel(x, y);

                    if (lessSignificant)
                    {
                        red = pixel.R - (pixel.R % 2);
                        red += lastCharacter[lastCharacterIndex] - '0';

                        image.SetPixel(x, y, Color.FromArgb(red, pixel.G, pixel.B));

                    }
                    else
                    {
                        if (pixel.R >= 128)
                        {
                            red = pixel.R - 128;
                        }
                        else
                        {
                            red = pixel.R;
                        }

                        red += (lastCharacter[lastCharacterIndex] - '0') * 128;

                        image.SetPixel(x, y, Color.FromArgb(red, pixel.G, pixel.B));
                    }
                }
            }
        }


        private void decriptLessSignificant(Bitmap image)
        {
            string finalMeasge = "";
            int charInt;
            char charTemp;

            string charBinary = "";
            int binaryIndex = -1;

            Color pixel;
            int red;

            int x,y;

            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    binaryIndex++;

                    pixel= image.GetPixel(x, y);
                    red = pixel.R;

                    if(binaryIndex == 8)
                    {
                        charInt = Convert.ToInt32(charBinary, 2);
                        charTemp = Convert.ToChar(charInt);

                        finalMeasge += charTemp;

                        charBinary = "";
                        binaryIndex = 0;
                    }

                    charBinary += red % 2;
                }
            }

            textBox.Text = finalMeasge;
            MessageBox.Show("Ho finito di trascrivere il messaggio", "Fine");
            return;

        }

        private void decriptMoreSignificant(Bitmap image)
        {
            string finalMeasge = "";
            int charInt;
            char charTemp;

            string charBinary = "";
            int binaryIndex = -1;

            Color pixel;
            int red;

            int x, y;

            for (y = 0; y < image.Height; y++)
            {
                for (x = 0; x < image.Width; x++)
                {
                    binaryIndex++;

                    pixel = image.GetPixel(x, y);
                    red = pixel.R;

                    if (binaryIndex == 8)
                    {
                        charInt = Convert.ToInt32(charBinary, 2);
                        charTemp = Convert.ToChar(charInt);

                        finalMeasge += charTemp;

                        charBinary = "";
                        binaryIndex = 0;
                    }

                    if(red >= 128)
                    {
                        charBinary += "1";
                    }
                    else
                    {
                        charBinary += "0";
                    }
                }
            }

            textBox.Text = finalMeasge;
            MessageBox.Show("Ho finito di trascrivere il messaggio", "Fine");
            return;

        }
    }
}