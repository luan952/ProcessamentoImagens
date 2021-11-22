using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trabalho_processamento
{
	public partial class Form2 : MetroFramework.Forms.MetroForm
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			while (progressBar1.Value != 100)
			{
				progressBar1.Value += 5;
				System.Threading.Thread.Sleep(200);
			}
			
			Form1 frm = new Form1();
			frm.ShowDialog();
			progressBar1.Value = 0;
		}
	}
}
