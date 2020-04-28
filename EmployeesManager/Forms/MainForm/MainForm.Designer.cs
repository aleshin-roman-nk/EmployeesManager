namespace EmployeesManager
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.gridMain = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnPaySelected = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreateDocument = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gridWorks = new System.Windows.Forms.DataGridView();
			this.txtEmployeeFIO = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWorks)).BeginInit();
			this.SuspendLayout();
			// 
			// gridMain
			// 
			this.gridMain.AllowUserToAddRows = false;
			this.gridMain.AllowUserToDeleteRows = false;
			this.gridMain.AllowUserToResizeRows = false;
			this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMain.ContextMenuStrip = this.contextMenuStrip1;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMain.DefaultCellStyle = dataGridViewCellStyle4;
			this.gridMain.Location = new System.Drawing.Point(0, 32);
			this.gridMain.Name = "gridMain";
			this.gridMain.RowHeadersVisible = false;
			this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMain.Size = new System.Drawing.Size(653, 496);
			this.gridMain.TabIndex = 0;
			this.gridMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridMain_KeyDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateToolStripMenuItem,
            this.btnDeleteToolStripMenuItem,
            this.btnPaySelected});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(230, 94);
			// 
			// btnCreateToolStripMenuItem
			// 
			this.btnCreateToolStripMenuItem.Image = global::EmployeesManager.Properties.Resources.icons8_create_24;
			this.btnCreateToolStripMenuItem.Name = "btnCreateToolStripMenuItem";
			this.btnCreateToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
			this.btnCreateToolStripMenuItem.Text = "Создать документ";
			this.btnCreateToolStripMenuItem.Click += new System.EventHandler(this.btnCreateToolStripMenuItem_Click);
			// 
			// btnDeleteToolStripMenuItem
			// 
			this.btnDeleteToolStripMenuItem.Image = global::EmployeesManager.Properties.Resources.icons8_delete_bin_24;
			this.btnDeleteToolStripMenuItem.Name = "btnDeleteToolStripMenuItem";
			this.btnDeleteToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
			this.btnDeleteToolStripMenuItem.Text = "Удалить документ";
			this.btnDeleteToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteToolStripMenuItem_Click);
			// 
			// btnPaySelected
			// 
			this.btnPaySelected.Image = global::EmployeesManager.Properties.Resources.icons8_request_money_24;
			this.btnPaySelected.Name = "btnPaySelected";
			this.btnPaySelected.Size = new System.Drawing.Size(229, 30);
			this.btnPaySelected.Text = "Оплатить документ";
			this.btnPaySelected.Click += new System.EventHandler(this.btnPaySelected_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateDocument,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1313, 57);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnCreateDocument
			// 
			this.btnCreateDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCreateDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDocument.Image")));
			this.btnCreateDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreateDocument.Name = "btnCreateDocument";
			this.btnCreateDocument.Size = new System.Drawing.Size(52, 54);
			this.btnCreateDocument.Text = "Создать документ (INS)";
			this.btnCreateDocument.Click += new System.EventHandler(this.btnCreateDocument_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(52, 54);
			this.toolStripButton2.Text = "Создать работу";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1315, 72);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.gridWorks);
			this.panel2.Controls.Add(this.txtEmployeeFIO);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Controls.Add(this.gridMain);
			this.panel2.Location = new System.Drawing.Point(0, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1315, 528);
			this.panel2.TabIndex = 3;
			// 
			// gridWorks
			// 
			this.gridWorks.AllowUserToAddRows = false;
			this.gridWorks.AllowUserToDeleteRows = false;
			this.gridWorks.AllowUserToResizeRows = false;
			this.gridWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridWorks.BackgroundColor = System.Drawing.Color.Silver;
			this.gridWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridWorks.Location = new System.Drawing.Point(659, 32);
			this.gridWorks.Name = "gridWorks";
			this.gridWorks.ReadOnly = true;
			this.gridWorks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridWorks.Size = new System.Drawing.Size(656, 496);
			this.gridWorks.TabIndex = 1;
			this.gridWorks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridWorks_KeyDown);
			// 
			// txtEmployeeFIO
			// 
			this.txtEmployeeFIO.AutoSize = true;
			this.txtEmployeeFIO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtEmployeeFIO.Location = new System.Drawing.Point(655, 10);
			this.txtEmployeeFIO.Name = "txtEmployeeFIO";
			this.txtEmployeeFIO.Size = new System.Drawing.Size(39, 19);
			this.txtEmployeeFIO.TabIndex = 2;
			this.txtEmployeeFIO.Text = "000";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(1, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(273, 26);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1315, 588);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "0";
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWorks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView gridMain;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCreateDocument;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label txtEmployeeFIO;
		private System.Windows.Forms.DataGridView gridWorks;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnCreateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnDeleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnPaySelected;
	}
}

