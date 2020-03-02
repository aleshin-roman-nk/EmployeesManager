namespace EmployeesEditor.Controls
{
	partial class FIOPanel
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtThirdName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSecondName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.acceptCancelPanelIP = new EmployeesEditor.Controls.AcceptCancelPanel();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.acceptCancelPanelIP);
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(601, 178);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ФИО";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel2.Controls.Add(this.txtThirdName, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtSecondName, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtFirstName, 1, 2);
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 99);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// txtThirdName
			// 
			this.txtThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtThirdName.Location = new System.Drawing.Point(159, 67);
			this.txtThirdName.Name = "txtThirdName";
			this.txtThirdName.Size = new System.Drawing.Size(427, 26);
			this.txtThirdName.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Фамилия";
			// 
			// txtSecondName
			// 
			this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSecondName.Location = new System.Drawing.Point(159, 3);
			this.txtSecondName.Name = "txtSecondName";
			this.txtSecondName.Size = new System.Drawing.Size(427, 26);
			this.txtSecondName.TabIndex = 10;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtFirstName.Location = new System.Drawing.Point(159, 35);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(427, 26);
			this.txtFirstName.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(3, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Имя";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Отчество";
			// 
			// acceptCancelPanelIP
			// 
			this.acceptCancelPanelIP.Location = new System.Drawing.Point(259, 130);
			this.acceptCancelPanelIP.Name = "acceptCancelPanelIP";
			this.acceptCancelPanelIP.Size = new System.Drawing.Size(336, 47);
			this.acceptCancelPanelIP.TabIndex = 14;
			this.acceptCancelPanelIP.Edit += new System.Action(this.acceptCancelPanelIP_Edit);
			this.acceptCancelPanelIP.Cancel += new System.Action(this.acceptCancelPanelIP_Cancel);
			this.acceptCancelPanelIP.Accept += new System.Action(this.acceptCancelPanelIP_Accept);
			// 
			// FIOPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.groupBox2);
			this.Name = "FIOPanel";
			this.Size = new System.Drawing.Size(607, 187);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private AcceptCancelPanel acceptCancelPanelIP;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox txtThirdName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSecondName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
	}
}
