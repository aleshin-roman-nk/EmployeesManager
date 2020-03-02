namespace EmployeesEditor.Controls
{
	partial class PassportPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.acceptCancelPanelPassport = new EmployeesEditor.Controls.AcceptCancelPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassportNumber = new System.Windows.Forms.TextBox();
			this.txtPassportIssuedBy = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIssuedDate = new System.Windows.Forms.DateTimePicker();
			this.txtBornDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.acceptCancelPanelPassport);
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(601, 208);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Паспорт";
			// 
			// acceptCancelPanelPassport
			// 
			this.acceptCancelPanelPassport.Location = new System.Drawing.Point(259, 160);
			this.acceptCancelPanelPassport.Name = "acceptCancelPanelPassport";
			this.acceptCancelPanelPassport.Size = new System.Drawing.Size(336, 47);
			this.acceptCancelPanelPassport.TabIndex = 6;
			this.acceptCancelPanelPassport.Edit += new System.Action(this.acceptCancelPanelPassport_Edit);
			this.acceptCancelPanelPassport.Cancel += new System.Action(this.acceptCancelPanelPassport_Cancel);
			this.acceptCancelPanelPassport.Accept += new System.Action(this.acceptCancelPanelPassport_Accept);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtPassportNumber, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtPassportIssuedBy, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtIssuedDate, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtBornDate, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 129);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Номер";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Дата рождения";
			// 
			// txtPassportNumber
			// 
			this.txtPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPassportNumber.Location = new System.Drawing.Point(159, 3);
			this.txtPassportNumber.Name = "txtPassportNumber";
			this.txtPassportNumber.Size = new System.Drawing.Size(427, 26);
			this.txtPassportNumber.TabIndex = 10;
			// 
			// txtPassportIssuedBy
			// 
			this.txtPassportIssuedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPassportIssuedBy.Location = new System.Drawing.Point(159, 67);
			this.txtPassportIssuedBy.Name = "txtPassportIssuedBy";
			this.txtPassportIssuedBy.Size = new System.Drawing.Size(427, 26);
			this.txtPassportIssuedBy.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Дата выдачи";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Кем выдан";
			// 
			// txtIssuedDate
			// 
			this.txtIssuedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtIssuedDate.Location = new System.Drawing.Point(159, 35);
			this.txtIssuedDate.Name = "txtIssuedDate";
			this.txtIssuedDate.Size = new System.Drawing.Size(200, 26);
			this.txtIssuedDate.TabIndex = 12;
			// 
			// txtBornDate
			// 
			this.txtBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBornDate.Location = new System.Drawing.Point(159, 99);
			this.txtBornDate.Name = "txtBornDate";
			this.txtBornDate.Size = new System.Drawing.Size(200, 26);
			this.txtBornDate.TabIndex = 13;
			// 
			// PassportPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.groupBox1);
			this.Name = "PassportPanel";
			this.Size = new System.Drawing.Size(607, 215);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private AcceptCancelPanel acceptCancelPanelPassport;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassportNumber;
		private System.Windows.Forms.TextBox txtPassportIssuedBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker txtIssuedDate;
		private System.Windows.Forms.DateTimePicker txtBornDate;
	}
}
