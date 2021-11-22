using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_processamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image1, image2, image3, image4;

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start3 = new ProcessStartInfo();
            start3.FileName = "Python.exe";
            start3.Arguments = "./Add.py";
            start3.UseShellExecute = false;
            start3.RedirectStandardOutput = true;
            Process.Start(start3).WaitForExit();

            image3 = new Bitmap(Image.FromFile(caminhoExecutavel() + "\\imagemSoma.png"));
            pictureBox3.Image = image3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "Python.exe";
            start.Arguments = "./Gaussian.py";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            Process.Start(start).WaitForExit();

            image2 = new Bitmap(Image.FromFile(caminhoExecutavel() + "\\ImagemGaussiana.jpg"));
            pictureBox2.Image = image2;
        }

        public string caminhoExecutavel()
        {
            string caminhoExecutavel = System.Reflection.Assembly.GetCallingAssembly().Location;
            string pastaExecutavel = new System.IO.FileInfo(caminhoExecutavel).DirectoryName;
            return pastaExecutavel += @"\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image1;
            }

            pictureBox1.Image.Save(caminhoExecutavel() + "img1.png", System.Drawing.Imaging.ImageFormat.Bmp);
            button1.Enabled = false;
        }
    }
}
