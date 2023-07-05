
namespace Project
{
	partial class GlavnaForma
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label vrijeme_uzimanjaLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label dan_uzimanjaLabel;
            System.Windows.Forms.Label ime_lijekaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelDataSet = new Project.ModelDataSet();
            this.podaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podaciTableAdapter = new Project.ModelDataSetTableAdapters.PodaciTableAdapter();
            this.tableAdapterManager = new Project.ModelDataSetTableAdapters.TableAdapterManager();
            this.podaciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.podaciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.vrijeme_uzimanjaTextBox = new System.Windows.Forms.TextBox();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.dan_uzimanjaTextBox = new System.Windows.Forms.TextBox();
            this.ime_lijekaTextBox = new System.Windows.Forms.TextBox();
            this.podaciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.Button();
            this.procesOznaka = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.spremi = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.danUzimanja = new System.Windows.Forms.ToolTip(this.components);
            this.vrijemeUzimanja = new System.Windows.Forms.ToolTip(this.components);
            idLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            vrijeme_uzimanjaLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            dan_uzimanjaLabel = new System.Windows.Forms.Label();
            ime_lijekaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingNavigator)).BeginInit();
            this.podaciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(59, 71);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(113, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Redni broj lijeka:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(59, 103);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(59, 135);
            prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(63, 17);
            prezimeLabel.TabIndex = 5;
            prezimeLabel.Text = "Prezime:";
            // 
            // vrijeme_uzimanjaLabel
            // 
            vrijeme_uzimanjaLabel.AutoSize = true;
            vrijeme_uzimanjaLabel.Location = new System.Drawing.Point(59, 167);
            vrijeme_uzimanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vrijeme_uzimanjaLabel.Name = "vrijeme_uzimanjaLabel";
            vrijeme_uzimanjaLabel.Size = new System.Drawing.Size(119, 17);
            vrijeme_uzimanjaLabel.TabIndex = 7;
            vrijeme_uzimanjaLabel.Text = "Vrijeme uzimanja:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(59, 199);
            kolicinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 9;
            kolicinaLabel.Text = "Kolicina:";
            // 
            // dan_uzimanjaLabel
            // 
            dan_uzimanjaLabel.AutoSize = true;
            dan_uzimanjaLabel.Location = new System.Drawing.Point(59, 231);
            dan_uzimanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dan_uzimanjaLabel.Name = "dan_uzimanjaLabel";
            dan_uzimanjaLabel.Size = new System.Drawing.Size(98, 17);
            dan_uzimanjaLabel.TabIndex = 11;
            dan_uzimanjaLabel.Text = "Dan uzimanja:";
            // 
            // ime_lijekaLabel
            // 
            ime_lijekaLabel.AutoSize = true;
            ime_lijekaLabel.Location = new System.Drawing.Point(59, 263);
            ime_lijekaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ime_lijekaLabel.Name = "ime_lijekaLabel";
            ime_lijekaLabel.Size = new System.Drawing.Size(70, 17);
            ime_lijekaLabel.TabIndex = 13;
            ime_lijekaLabel.Text = "Ime lijeka:";
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // podaciBindingSource
            // 
            this.podaciBindingSource.DataMember = "Podaci";
            this.podaciBindingSource.DataSource = this.modelDataSet;
            // 
            // podaciTableAdapter
            // 
            this.podaciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PodaciTableAdapter = this.podaciTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // podaciBindingNavigator
            // 
            this.podaciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.podaciBindingNavigator.BindingSource = this.podaciBindingSource;
            this.podaciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.podaciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.podaciBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.podaciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.podaciBindingNavigatorSaveItem});
            this.podaciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.podaciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.podaciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.podaciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.podaciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.podaciBindingNavigator.Name = "podaciBindingNavigator";
            this.podaciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.podaciBindingNavigator.Size = new System.Drawing.Size(1014, 31);
            this.podaciBindingNavigator.TabIndex = 0;
            this.podaciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // podaciBindingNavigatorSaveItem
            // 
            this.podaciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.podaciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("podaciBindingNavigatorSaveItem.Image")));
            this.podaciBindingNavigatorSaveItem.Name = "podaciBindingNavigatorSaveItem";
            this.podaciBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.podaciBindingNavigatorSaveItem.Text = "Save Data";
            this.podaciBindingNavigatorSaveItem.Click += new System.EventHandler(this.podaciBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(184, 68);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(184, 100);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(132, 22);
            this.imeTextBox.TabIndex = 4;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(184, 132);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(132, 22);
            this.prezimeTextBox.TabIndex = 6;
            // 
            // vrijeme_uzimanjaTextBox
            // 
            this.vrijeme_uzimanjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Vrijeme uzimanja", true));
            this.vrijeme_uzimanjaTextBox.Location = new System.Drawing.Point(184, 164);
            this.vrijeme_uzimanjaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vrijeme_uzimanjaTextBox.Name = "vrijeme_uzimanjaTextBox";
            this.vrijeme_uzimanjaTextBox.Size = new System.Drawing.Size(132, 22);
            this.vrijeme_uzimanjaTextBox.TabIndex = 8;
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Kolicina", true));
            this.kolicinaTextBox.Location = new System.Drawing.Point(184, 196);
            this.kolicinaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(132, 22);
            this.kolicinaTextBox.TabIndex = 10;
            // 
            // dan_uzimanjaTextBox
            // 
            this.dan_uzimanjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Dan uzimanja", true));
            this.dan_uzimanjaTextBox.Location = new System.Drawing.Point(184, 228);
            this.dan_uzimanjaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dan_uzimanjaTextBox.Name = "dan_uzimanjaTextBox";
            this.dan_uzimanjaTextBox.Size = new System.Drawing.Size(132, 22);
            this.dan_uzimanjaTextBox.TabIndex = 12;
            // 
            // ime_lijekaTextBox
            // 
            this.ime_lijekaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podaciBindingSource, "Ime lijeka", true));
            this.ime_lijekaTextBox.Location = new System.Drawing.Point(184, 260);
            this.ime_lijekaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ime_lijekaTextBox.Name = "ime_lijekaTextBox";
            this.ime_lijekaTextBox.Size = new System.Drawing.Size(132, 22);
            this.ime_lijekaTextBox.TabIndex = 14;
            // 
            // podaciDataGridView
            // 
            this.podaciDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.podaciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.podaciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podaciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.podaciDataGridView.DataSource = this.podaciBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.podaciDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.podaciDataGridView.Location = new System.Drawing.Point(63, 340);
            this.podaciDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.podaciDataGridView.Name = "podaciDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.podaciDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.podaciDataGridView.RowHeadersWidth = 51;
            this.podaciDataGridView.Size = new System.Drawing.Size(930, 169);
            this.podaciDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vrijeme uzimanja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vrijeme uzimanja";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dan uzimanja";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dan uzimanja";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ime lijeka";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ime lijeka";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(547, 71);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 28);
            this.start.TabIndex = 16;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // procesOznaka
            // 
            this.procesOznaka.AutoSize = true;
            this.procesOznaka.Location = new System.Drawing.Point(408, 108);
            this.procesOznaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.procesOznaka.Name = "procesOznaka";
            this.procesOznaka.Size = new System.Drawing.Size(421, 17);
            this.procesOznaka.TabIndex = 17;
            this.procesOznaka.Text = "Uspješno ste započeli proces. Alarm će se oglasiti pravovremeno!";
            this.procesOznaka.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(386, 211);
            this.spremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(140, 28);
            this.spremi.TabIndex = 18;
            this.spremi.Text = "Export table";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(673, 211);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(140, 28);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "Import Table";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 528);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.procesOznaka);
            this.Controls.Add(this.start);
            this.Controls.Add(this.podaciDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(vrijeme_uzimanjaLabel);
            this.Controls.Add(this.vrijeme_uzimanjaTextBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(dan_uzimanjaLabel);
            this.Controls.Add(this.dan_uzimanjaTextBox);
            this.Controls.Add(ime_lijekaLabel);
            this.Controls.Add(this.ime_lijekaTextBox);
            this.Controls.Add(this.podaciBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm za ljekove";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaciBindingNavigator)).EndInit();
            this.podaciBindingNavigator.ResumeLayout(false);
            this.podaciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podaciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ModelDataSet modelDataSet;
		private System.Windows.Forms.BindingSource podaciBindingSource;
		private ModelDataSetTableAdapters.PodaciTableAdapter podaciTableAdapter;
		private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator podaciBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton podaciBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox imeTextBox;
		private System.Windows.Forms.TextBox prezimeTextBox;
		private System.Windows.Forms.TextBox vrijeme_uzimanjaTextBox;
		private System.Windows.Forms.TextBox kolicinaTextBox;
		private System.Windows.Forms.TextBox dan_uzimanjaTextBox;
		private System.Windows.Forms.TextBox ime_lijekaTextBox;
		private System.Windows.Forms.DataGridView podaciDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Label procesOznaka;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip danUzimanja;
        private System.Windows.Forms.ToolTip vrijemeUzimanja;
    }
}

