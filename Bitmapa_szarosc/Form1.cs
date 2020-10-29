using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmapa_szarosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog openFileDialog = new OpenFileDialog();



                openFileDialog.DefaultExt = ".png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // label1.Content = openFileDialog.FileName;
                    // img1.Source = new BitmapImage(new Uri(openFileDialog.FileName));

                    Bitmap bm = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    Bitmap szary = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    int x, y, s;


                    for (x = 0; x < bm.Width; x++)
                    {
                        for (y = 0; y < bm.Height; y++)
                        {
                            Color pixelColor = bm.GetPixel(x, y);

                            s = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            szary.SetPixel(x, y, Color.FromArgb(s, s, s));

                            pictureBox1.Image = szary;


                        }
                    }



                }

            

           
        }
    }
}
