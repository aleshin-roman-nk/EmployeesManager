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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gridMain = new System.Windows.Forms.DataGridView();
			this.employeeControl1 = new EmployeesManager.Forms.MainForm.SubElements.EmployeeControl();
			this.workDokumentsPanel = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.monthsPanel = new System.Windows.Forms.Panel();
			this.lblCurrentMonth = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.yearsPanel = new System.Windows.Forms.Panel();
			this.btnCreateYear = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFIO = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuilding = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
			this.workDokumentsPanel.SuspendLayout();
			this.monthsPanel.SuspendLayout();
			this.yearsPanel.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gridMain);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.employeeControl1);
			this.splitContainer1.Panel2.Controls.Add(this.workDokumentsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.monthsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.yearsPanel);
			this.splitContainer1.Size = new System.Drawing.Size(800, 420);
			this.splitContainer1.SplitterDistance = 345;
			this.splitContainer1.TabIndex = 1;
			// 
			// gridMain
			// 
			this.gridMain.AllowUserToAddRows = false;
			this.gridMain.AllowUserToDeleteRows = false;
			this.gridMain.AllowUserToResizeRows = false;
			this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMain.Location = new System.Drawing.Point(0, 0);
			this.gridMain.Name = "gridMain";
			this.gridMain.RowHeadersVisible = false;
			this.gridMain.Size = new System.Drawing.Size(343, 418);
			this.gridMain.TabIndex = 0;
			this.gridMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
			// 
			// employeeControl1
			// 
			this.employeeControl1.EmployeeName = "Employee";
			this.employeeControl1.Location = new System.Drawing.Point(20, 332);
			this.employeeControl1.Name = "employeeControl1";
			this.employeeControl1.Size = new System.Drawing.Size(302, 277);
			this.employeeControl1.TabIndex = 8;
			// 
			// workDokumentsPanel
			// 
			this.workDokumentsPanel.Controls.Add(this.label6);
			this.workDokumentsPanel.Controls.Add(this.label5);
			this.workDokumentsPanel.Location = new System.Drawing.Point(232, 7);
			this.workDokumentsPanel.Name = "workDokumentsPanel";
			this.workDokumentsPanel.Size = new System.Drawing.Size(190, 200);
			this.workDokumentsPanel.TabIndex = 7;
			this.workDokumentsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workDokumentsPanel_Paint);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(136, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "End";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Документы работ";
			// 
			// monthsPanel
			// 
			this.monthsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.monthsPanel.Controls.Add(this.lblCurrentMonth);
			this.monthsPanel.Controls.Add(this.label3);
			this.monthsPanel.Location = new System.Drawing.Point(13, 5);
			this.monthsPanel.Name = "monthsPanel";
			this.monthsPanel.Size = new System.Drawing.Size(200, 100);
			this.monthsPanel.TabIndex = 6;
			// 
			// lblCurrentMonth
			// 
			this.lblCurrentMonth.AutoSize = true;
			this.lblCurrentMonth.Location = new System.Drawing.Point(11, 40);
			this.lblCurrentMonth.Name = "lblCurrentMonth";
			this.lblCurrentMonth.Size = new System.Drawing.Size(13, 13);
			this.lblCurrentMonth.TabIndex = 1;
			this.lblCurrentMonth.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "МЕСЯЦЫ";
			// 
			// yearsPanel
			// 
			this.yearsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.yearsPanel.Controls.Add(this.btnCreateYear);
			this.yearsPanel.Controls.Add(this.label7);
			this.yearsPanel.Controls.Add(this.txtFIO);
			this.yearsPanel.Controls.Add(this.label1);
			this.yearsPanel.Controls.Add(this.txtBuilding);
			this.yearsPanel.Controls.Add(this.txtStreet);
			this.yearsPanel.Controls.Add(this.label2);
			this.yearsPanel.Location = new System.Drawing.Point(13, 132);
			this.yearsPanel.Name = "yearsPanel";
			this.yearsPanel.Size = new System.Drawing.Size(330, 173);
			this.yearsPanel.TabIndex = 5;
			// 
			// btnCreateYear
			// 
			this.btnCreateYear.Location = new System.Drawing.Point(46, 3);
			this.btnCreateYear.Name = "btnCreateYear";
			this.btnCreateYear.Size = new System.Drawing.Size(115, 23);
			this.btnCreateYear.TabIndex = 6;
			this.btnCreateYear.Text = "Создать год";
			this.btnCreateYear.UseVisualStyleBackColor = true;
			this.btnCreateYear.Click += new System.EventHandler(this.BtnCreateYear_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "ГОДА";
			// 
			// txtFIO
			// 
			this.txtFIO.AutoSize = true;
			this.txtFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtFIO.Location = new System.Drawing.Point(9, 36);
			this.txtFIO.Name = "txtFIO";
			this.txtFIO.Size = new System.Drawing.Size(19, 20);
			this.txtFIO.TabIndex = 4;
			this.txtFIO.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Улица";
			// 
			// txtBuilding
			// 
			this.txtBuilding.Location = new System.Drawing.Point(76, 80);
			this.txtBuilding.Name = "txtBuilding";
			this.txtBuilding.ReadOnly = true;
			this.txtBuilding.Size = new System.Drawing.Size(203, 20);
			this.txtBuilding.TabIndex = 3;
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(76, 106);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.ReadOnly = true;
			this.txtStreet.Size = new System.Drawing.Size(203, 20);
			this.txtStreet.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Дом";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(798, 28);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 25);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 30);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.splitContainer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 30);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 420);
			this.panel2.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "0";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
			this.workDokumentsPanel.ResumeLayout(false);
			this.workDokumentsPanel.PerformLayout();
			this.monthsPanel.ResumeLayout(false);
			this.monthsPanel.PerformLayout();
			this.yearsPanel.ResumeLayout(false);
			this.yearsPanel.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView gridMain;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuilding;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtFIO;
		private System.Windows.Forms.Panel yearsPanel;
		private System.Windows.Forms.Panel monthsPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCurrentMonth;
		private System.Windows.Forms.Panel workDokumentsPanel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private Forms.MainForm.SubElements.EmployeeControl employeeControl1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCreateYear;
	}
}

