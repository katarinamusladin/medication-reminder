
namespace Project
{
	partial class Uvod
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uvod));
            this.Nastavak = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uvodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nastavak
            // 
            this.Nastavak.Location = new System.Drawing.Point(221, 244);
            this.Nastavak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nastavak.Name = "Nastavak";
            this.Nastavak.Size = new System.Drawing.Size(100, 28);
            this.Nastavak.TabIndex = 0;
            this.Nastavak.Text = "Nastavak";
            this.toolTip1.SetToolTip(this.Nastavak, "Ovaj gumb će vas preusmjeriti dalje na program!");
            this.Nastavak.UseVisualStyleBackColor = true;
            this.Nastavak.Click += new System.EventHandler(this.Nastavak_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // uvodLabel
            // 
            this.uvodLabel.AutoSize = true;
            this.uvodLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uvodLabel.Location = new System.Drawing.Point(21, 65);
            this.uvodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uvodLabel.Name = "uvodLabel";
            this.uvodLabel.Size = new System.Drawing.Size(523, 29);
            this.uvodLabel.TabIndex = 1;
            this.uvodLabel.Text = "Dobro došli u program koji se brine o Vašem zdravlju!";
            this.uvodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uvodLabel.Click += new System.EventHandler(this.uvodLabel_Click);
            // 
            // Uvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 287);
            this.Controls.Add(this.uvodLabel);
            this.Controls.Add(this.Nastavak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Nastavak;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label uvodLabel;
	}
}