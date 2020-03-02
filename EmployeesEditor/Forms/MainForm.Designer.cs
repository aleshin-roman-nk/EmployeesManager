namespace EmployeesEditor
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridEmployee = new System.Windows.Forms.DataGridView();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uIEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAddEmployee = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.fioPanel1 = new EmployeesEditor.Controls.FIOPanel();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.passportPanel1 = new EmployeesEditor.Controls.PassportPanel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ipPanel1 = new EmployeesEditor.Controls.IPPanel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.addressPanel1 = new EmployeesEditor.Controls.AddressPanel();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.bankPanel1 = new EmployeesEditor.Controls.BankPanel();
			this.txtFIO = new System.Windows.Forms.Label();
			this.btnGenerateContracts = new System.Windows.Forms.Button();
			this.btnRemoveEmployee = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uIEmployeeBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridEmployee
			// 
			this.gridEmployee.AllowUserToAddRows = false;
			this.gridEmployee.AllowUserToDeleteRows = false;
			this.gridEmployee.AllowUserToResizeColumns = false;
			this.gridEmployee.AllowUserToResizeRows = false;
			this.gridEmployee.AutoGenerateColumns = false;
			this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
			this.gridEmployee.DataSource = this.uIEmployeeBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridEmployee.Location = new System.Drawing.Point(12, 12);
			this.gridEmployee.Name = "gridEmployee";
			this.gridEmployee.ReadOnly = true;
			this.gridEmployee.RowHeadersVisible = false;
			this.gridEmployee.Size = new System.Drawing.Size(630, 299);
			this.gridEmployee.TabIndex = 0;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.fullNameDataGridViewTextBoxColumn.Width = 500;
			// 
			// uIEmployeeBindingSource
			// 
			this.uIEmployeeBindingSource.DataSource = typeof(EmModel.Entities.UI.UIEmployee);
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.Location = new System.Drawing.Point(567, 317);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
			this.btnAddEmployee.TabIndex = 1;
			this.btnAddEmployee.Text = "Создать";
			this.btnAddEmployee.UseVisualStyleBackColor = true;
			this.btnAddEmployee.Click += new System.EventHandler(this.CreateEmployee_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(8, 346);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(634, 433);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.fioPanel1);
			this.tabPage5.Location = new System.Drawing.Point(4, 29);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(626, 400);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "ФИО";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// fioPanel1
			// 
			this.fioPanel1.Location = new System.Drawing.Point(3, 3);
			this.fioPanel1.Name = "fioPanel1";
			this.fioPanel1.Size = new System.Drawing.Size(607, 187);
			this.fioPanel1.TabIndex = 0;
			this.fioPanel1.Store += new System.Action<EmModel.Entities.UI.UIEmployee>(this.fioPanel1_Store);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.passportPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(626, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Паспорт";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// passportPanel1
			// 
			this.passportPanel1.Location = new System.Drawing.Point(6, 6);
			this.passportPanel1.Name = "passportPanel1";
			this.passportPanel1.Size = new System.Drawing.Size(607, 215);
			this.passportPanel1.TabIndex = 0;
			this.passportPanel1.Store += new System.Action<EmModel.Entities.UI.UIEmployee>(this.passportPanel1_Store);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.ipPanel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(626, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "ИП";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ipPanel1
			// 
			this.ipPanel1.Location = new System.Drawing.Point(6, 6);
			this.ipPanel1.Name = "ipPanel1";
			this.ipPanel1.Size = new System.Drawing.Size(608, 407);
			this.ipPanel1.TabIndex = 0;
			this.ipPanel1.Store += new System.Action<EmModel.Entities.UI.UIEmployee>(this.ipPanel1_Store);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.addressPanel1);
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(626, 400);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Адрес";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// addressPanel1
			// 
			this.addressPanel1.Location = new System.Drawing.Point(3, 3);
			this.addressPanel1.Name = "addressPanel1";
			this.addressPanel1.Size = new System.Drawing.Size(608, 249);
			this.addressPanel1.TabIndex = 0;
			this.addressPanel1.Store += new System.Action<EmModel.Entities.UI.UIEmployee>(this.addressPanel1_Store);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.bankPanel1);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(626, 400);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Банк";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// bankPanel1
			// 
			this.bankPanel1.Location = new System.Drawing.Point(3, 3);
			this.bankPanel1.Name = "bankPanel1";
			this.bankPanel1.Size = new System.Drawing.Size(607, 217);
			this.bankPanel1.TabIndex = 0;
			this.bankPanel1.Store += new System.Action<EmModel.Entities.UI.UIEmployee>(this.bankPanel1_Store_1);
			// 
			// txtFIO
			// 
			this.txtFIO.AutoSize = true;
			this.txtFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtFIO.Location = new System.Drawing.Point(4, 317);
			this.txtFIO.Name = "txtFIO";
			this.txtFIO.Size = new System.Drawing.Size(43, 24);
			this.txtFIO.TabIndex = 6;
			this.txtFIO.Text = "000";
			// 
			// btnGenerateContracts
			// 
			this.btnGenerateContracts.Location = new System.Drawing.Point(486, 317);
			this.btnGenerateContracts.Name = "btnGenerateContracts";
			this.btnGenerateContracts.Size = new System.Drawing.Size(75, 23);
			this.btnGenerateContracts.TabIndex = 1;
			this.btnGenerateContracts.Text = "Договоры";
			this.btnGenerateContracts.UseVisualStyleBackColor = true;
			this.btnGenerateContracts.Click += new System.EventHandler(this.btnGenerateContracts_Click);
			// 
			// btnRemoveEmployee
			// 
			this.btnRemoveEmployee.BackColor = System.Drawing.Color.Red;
			this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRemoveEmployee.ForeColor = System.Drawing.Color.Yellow;
			this.btnRemoveEmployee.Location = new System.Drawing.Point(352, 317);
			this.btnRemoveEmployee.Name = "btnRemoveEmployee";
			this.btnRemoveEmployee.Size = new System.Drawing.Size(105, 37);
			this.btnRemoveEmployee.TabIndex = 7;
			this.btnRemoveEmployee.Text = "Удалить";
			this.btnRemoveEmployee.UseVisualStyleBackColor = false;
			this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 835);
			this.Controls.Add(this.btnRemoveEmployee);
			this.Controls.Add(this.btnGenerateContracts);
			this.Controls.Add(this.txtFIO);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.gridEmployee);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uIEmployeeBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridEmployee;
		private System.Windows.Forms.Button btnAddEmployee;
		private System.Windows.Forms.BindingSource uIEmployeeBindingSource;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private Controls.PassportPanel passportPanel1;
		private Controls.IPPanel ipPanel1;
		private Controls.AddressPanel addressPanel1;
		private Controls.BankPanel bankPanel1;
		private System.Windows.Forms.TabPage tabPage5;
		private Controls.FIOPanel fioPanel1;
		private System.Windows.Forms.Label txtFIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnGenerateContracts;
		private System.Windows.Forms.Button btnRemoveEmployee;
	}
}

