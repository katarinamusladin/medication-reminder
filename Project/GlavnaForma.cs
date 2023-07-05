using ClosedXML.Excel;
using Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Project
{
	public partial class GlavnaForma : Form
	{
		string dan; 
		System.Timers.Timer timer;
		ObradaPodataka obrada = new ObradaPodataka(); 
		public GlavnaForma() 
		{
			this.BackgroundImage = Properties.Resources.pill;
			this.BackgroundImageLayout = ImageLayout.Stretch; 
			this.FormClosing += GlavnaForma_FormClosing;
			InitializeComponent();
			toolTip1.SetToolTip(idTextBox, "Broj ljekova se uvećava za 1 svakim novim dodavanjem u listu."); 
			danUzimanja.SetToolTip(dan_uzimanjaTextBox, "Valjani dani za uzimanje tableta su svaki pojedinacni dan tjedna i riječ svi. Ne trebate paziti na velika i mala slova!");
			vrijemeUzimanja.SetToolTip(vrijeme_uzimanjaTextBox, "Format sati je HH:MM:SS. Upisite u tom obliku!");
		}

		public void GlavnaForma_Load(object sender, EventArgs e)
		{
			timer = new System.Timers.Timer();
			//timer.Interval = 1000;
			timer.Elapsed += Timer_Elapsed;
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			DateTime trenutnoVrijeme = DateTime.Now; 
			DateTime napisanoVrijeme = DateTime.Parse(vrijeme_uzimanjaTextBox.Text); 
			
			if (trenutnoVrijeme.Hour == napisanoVrijeme.TimeOfDay.Hours && trenutnoVrijeme.Minute == napisanoVrijeme.TimeOfDay.Minutes)
			{
				if (DateTime.Today.DayOfWeek.ToString() == dan || dan == "svi")
				{

					//Thread.Sleep(60000);
					timer.Stop();
					try
					{
						SoundPlayer zvuk = new SoundPlayer(); 
						zvuk.SoundLocation = @"C:\Users\alarm.wav"; 
						zvuk.Play();
						if (kolicinaTextBox.Text == "1") 
						{
							MessageBox.Show(imeTextBox.Text + " uzmi " + kolicinaTextBox.Text + " tabletu " + ime_lijekaTextBox.Text + "a", "Upozorenje!");
						}
						else
						{
							MessageBox.Show(imeTextBox.Text + " uzmi " + kolicinaTextBox.Text + " tablete " + ime_lijekaTextBox.Text + "a", " Upozorenje!");
						}
						Thread.Sleep(2000); 
						return;
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Message); 
					}
				}
			}
		}

		private void podaciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.podaciBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.modelDataSet);

		}
		private void Form1_Load(object sender, EventArgs e)
		{ 
			//Settings.Default.Save();
			// TODO: This line of code loads data into the 'modelDataSet.Podaci' table. You can move, or remove it, as needed.
			this.podaciTableAdapter.Fill(this.modelDataSet.Podaci);
			timer = new System.Timers.Timer();
			timer.Interval = 1000;
			timer.Elapsed += Timer_Elapsed;
		}

		private void idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void start_Click(object sender, EventArgs e)
		{
			dan = obrada.odrediDanEngl(dan_uzimanjaTextBox.Text, out string upisaniDanEngl); 
			string tmp = idTextBox.Text; 
			if (idTextBox.Text == String.Empty || imeTextBox.Text == String.Empty || prezimeTextBox.Text == String.Empty
				|| vrijeme_uzimanjaTextBox.Text == String.Empty || kolicinaTextBox.Text == String.Empty || dan_uzimanjaTextBox.Text == String.Empty ||
				ime_lijekaTextBox.Text == String.Empty) 
			{
				MessageBox.Show("Podaci o ljekovima nisu ispravno uneseni. Molimo provjerite ponovno sve podatke", "Upozorenje");
				return; 
			}
			procesOznaka.Visible = true; 
			procesOznaka.ForeColor = Color.Green; 
			timer.Start(); 
			//string poruka = obradaPodataka.pokreniAlarm();
			//if (poruka != null)
			//{
			//	MessageBox.Show(poruka);
			//}
			//while (flag)
			//{
			//	usporedi();
			//}
		}
		private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Save(); 
			if (e.CloseReason == CloseReason.WindowsShutDown) return;

			// Confirm user wants to close
			switch (MessageBox.Show("Jeste li sigurni da zelite izaci?", "Zatvaranje", MessageBoxButtons.YesNo))
			{
				case DialogResult.No:
					e.Cancel = true; 
					break;
				default:
					break; 
			}
	}
		
		public void usporedi()
		{
			DateTime vrijeme = DateTime.Parse(vrijeme_uzimanjaTextBox.Text);
			DateTime trenutno = DateTime.Now;
			if (vrijeme.Hour == DateTime.Now.Hour && vrijeme.Minute == DateTime.Now.Minute)
			{
				MessageBox.Show("Popij ljekove.");
			}
		}

		private void spremi_Click(object sender, EventArgs e)
		{
			
			CSVExport exportCSV = new CSVExport(); 
			exportCSV.export(this.modelDataSet.Podaci, out string response);
			if (response != String.Empty)
			{
				MessageBox.Show(response, "Informacija o exportu podataka");
			}
		}

        private void dan_uzimanjaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
			Import_table_form import_Table_Form = new Import_table_form();
			import_Table_Form.Show(); 
        }
    }
}
