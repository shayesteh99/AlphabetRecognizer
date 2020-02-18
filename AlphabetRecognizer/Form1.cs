using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetRecognizer
{
    public partial class Form1 : Form
    {
        public AlphabetProcessor Processor { get; set; }
        public Bitmap Bmp { get; set; }
        public Form1()
        {
            InitializeComponent();
            Processor = new AlphabetProcessor();
            Bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(Bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.MouseMove -= panel1_MouseMove;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.CreateGraphics().DrawRectangle(new Pen(Color.Black), e.X, e.Y, 1, 1);
            using(Graphics g = Graphics.FromImage(Bmp))
                g.DrawRectangle(new Pen(Color.Black), e.X, e.Y, 1, 1);
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            Bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool[,] coloredPixels = Bmp.GetColoredPixels();
            coloredPixels = coloredPixels.SetArraySize().MakeSquare().Scale();
            Processor.SaveAlphabet(coloredPixels, Convert.ToChar(textBox1.Text));
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            bool[,] coloredPixels = Bmp.GetColoredPixels();
            coloredPixels = coloredPixels.SetArraySize().MakeSquare().Scale();
            char c = Processor.Recognize(coloredPixels);
            textBox2.Text += c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            Bmp = Processor.DrawAlphabet(Convert.ToChar(textBox3.Text));
            panel1.CreateGraphics().DrawImage(Bmp, 50, 50);
        }




    }
}
