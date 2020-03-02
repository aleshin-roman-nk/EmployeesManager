namespace EmployeesEditor.Controls
{
	partial class IPPanel
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.acceptCancelPanelIP = new EmployeesEditor.Controls.AcceptCancelPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtOGRNIPDate = new System.Windows.Forms.DateTimePicker();
			this.txtINN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOGRNIP = new System.Windows.Forms.TextBox();
			this.txtOGRNIPIssuedBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtContractDate = new System.Windows.Forms.DateTimePicker();
			this.txtContractDateEnd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtContractNo = new System.Windows.Forms.TextBox();
			this.txtContractDuring = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(601, 331);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ИП";
			// 
			// acceptCancelPanelIP
			// 
			this.acceptCancelPanelIP.Location = new System.Drawing.Point(268, 340);
			this.acceptCancelPanelIP.Name = "acceptCancelPanelIP";
			this.acceptCancelPanelIP.Size = new System.Drawing.Size(336, 47);
			this.acceptCancelPanelIP.TabIndex = 14;
			this.acceptCancelPanelIP.Edit += new System.Action(this.acceptCancelPanelIP_Edit);
			this.acceptCancelPanelIP.Cancel += new System.Action(this.acceptCancelPanelIP_Cancel);
			this.acceptCancelPanelIP.Accept += new System.Action(this.acceptCancelPanelIP_Accept);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel2.Controls.Add(this.txtOGRNIPDate, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtINN, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtOGRNIP, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtOGRNIPIssuedBy, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 130);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// txtOGRNIPDate
			// 
			this.txtOGRNIPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtOGRNIPDate.Location = new System.Drawing.Point(159, 35);
			this.txtOGRNIPDate.Name = "txtOGRNIPDate";
			this.txtOGRNIPDate.Size = new System.Drawing.Size(200, 26);
			this.txtOGRNIPDate.TabIndex = 13;
			// 
			// txtINN
			// 
			this.txtINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtINN.Location = new System.Drawing.Point(159, 99);
			this.txtINN.Name = "txtINN";
			this.txtINN.Size = new System.Drawing.Size(427, 26);
			this.txtINN.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "ОГРНИП";
			// 
			// txtOGRNIP
			// 
			this.txtOGRNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtOGRNIP.Location = new System.Drawing.Point(159, 3);
			this.txtOGRNIP.Name = "txtOGRNIP";
			this.txtOGRNIP.Size = new System.Drawing.Size(427, 26);
			this.txtOGRNIP.TabIndex = 10;
			// 
			// txtOGRNIPIssuedBy
			// 
			this.txtOGRNIPIssuedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtOGRNIPIssuedBy.Location = new System.Drawing.Point(159, 67);
			this.txtOGRNIPIssuedBy.Name = "txtOGRNIPIssuedBy";
			this.txtOGRNIPIssuedBy.Size = new System.Drawing.Size(427, 26);
			this.txtOGRNIPIssuedBy.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(3, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Дата выдачи";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(3, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Кем выдан";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "ИНН";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(6, 161);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(589, 165);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Договор";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel1.Controls.Add(this.txtContractDate, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtContractDateEnd, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtContractNo, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtContractDuring, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 130);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// txtContractDate
			// 
			this.txtContractDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtContractDate.Location = new System.Drawing.Point(159, 35);
			this.txtContractDate.Name = "txtContractDate";
			this.txtContractDate.Size = new System.Drawing.Size(200, 26);
			this.txtContractDate.TabIndex = 13;
			// 
			// txtContractDateEnd
			// 
			this.txtContractDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtContractDateEnd.Location = new System.Drawing.Point(159, 99);
			this.txtContractDateEnd.Name = "txtContractDateEnd";
			this.txtContractDateEnd.Size = new System.Drawing.Size(427, 26);
			this.txtContractDateEnd.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "№";
			// 
			// txtContractNo
			// 
			this.txtContractNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtContractNo.Location = new System.Drawing.Point(159, 3);
			this.txtContractNo.Name = "txtContractNo";
			this.txtContractNo.Size = new System.Drawing.Size(427, 26);
			this.txtContractNo.TabIndex = 10;
			// 
			// txtContractDuring
			// 
			this.txtContractDuring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtContractDuring.Location = new System.Drawing.Point(159, 67);
			this.txtContractDuring.Name = "txtContractDuring";
			this.txtContractDuring.Size = new System.Drawing.Size(427, 26);
			this.txtContractDuring.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Дата";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Срок";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(3, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Дата завершения";
			// 
			// IPPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.acceptCancelPanelIP);
			this.Controls.Add(this.groupBox2);
			this.Name = "IPPanel";
			this.Size = new System.Drawing.Size(608, 391);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private AcceptCancelPanel acceptCancelPanelIP;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DateTimePicker txtOGRNIPDate;
		private System.Windows.Forms.TextBox txtINN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtOGRNIP;
		private System.Windows.Forms.TextBox txtOGRNIPIssuedBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DateTimePicker txtContractDate;
		private System.Windows.Forms.TextBox txtContractDateEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContractNo;
		private System.Windows.Forms.TextBox txtContractDuring;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
