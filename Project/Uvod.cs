using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class Uvod : Form
	{
		public Uvod()
		{
			this.BackgroundImage = Properties.Resources.pill;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			InitializeComponent();
			//uvodLabel.Text = "Dobro došli u program koji se brine o Vašem zdravlju!";
			//uvodLabel.AutoSize = false;
			//uvodLabel.TextAlign = ContentAlignment.MiddleCenter;
		//	uvodLabel.Dock = DockStyle.None;
			Left = 10;
			uvodLabel.Left = (this.ClientSize.Width - uvodLabel.Size.Width) / 2;
			//uvodLabel.Dock = DockStyle.Fill;
		}
		private void uvodLabel_SizeChanged(object sender, EventArgs e)
		{
			uvodLabel.Left = (this.ClientSize.Width - uvodLabel.Size.Width) / 2;
		}
		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}

		private void Nastavak_Click(object sender, EventArgs e)
		{
			GlavnaForma glavnaForma = new GlavnaForma();
			this.Hide();
			glavnaForma.Show();
			
		}

		private void uvodLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
