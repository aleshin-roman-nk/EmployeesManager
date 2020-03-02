namespace EmployeesEditor.Controls
{
	partial class BankPanel
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.acceptCancelPanelBank = new EmployeesEditor.Controls.AcceptCancelPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label14 = new System.Windows.Forms.Label();
			this.txtBankAccount = new System.Windows.Forms.TextBox();
			this.txtBankName = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtBIK = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCorrAcc = new System.Windows.Forms.TextBox();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.acceptCancelPanelBank);
			this.groupBox4.Controls.Add(this.tableLayoutPanel4);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.Location = new System.Drawing.Point(3, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(601, 208);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Банк";
			// 
			// acceptCancelPanelBank
			// 
			this.acceptCancelPanelBank.Location = new System.Drawing.Point(259, 160);
			this.acceptCancelPanelBank.Name = "acceptCancelPanelBank";
			this.acceptCancelPanelBank.Size = new System.Drawing.Size(336, 47);
			this.acceptCancelPanelBank.TabIndex = 6;
			this.acceptCancelPanelBank.Edit += new System.Action(this.acceptCancelPanelBank_Edit);
			this.acceptCancelPanelBank.Cancel += new System.Action(this.acceptCancelPanelBank_Cancel);
			this.acceptCancelPanelBank.Accept += new System.Action(this.acceptCancelPanelBank_Accept);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel4.Controls.Add(this.txtCorrAcc, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.label14, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.txtBankAccount, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.txtBankName, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.label16, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label17, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.txtBIK, 1, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 25);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(589, 129);
			this.tableLayoutPanel4.TabIndex = 5;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(3, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 20);
			this.label14.TabIndex = 9;
			this.label14.Text = "Счет";
			// 
			// txtBankAccount
			// 
			this.txtBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBankAccount.Location = new System.Drawing.Point(159, 3);
			this.txtBankAccount.Name = "txtBankAccount";
			this.txtBankAccount.Size = new System.Drawing.Size(427, 26);
			this.txtBankAccount.TabIndex = 10;
			// 
			// txtBankName
			// 
			this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBankName.Location = new System.Drawing.Point(159, 67);
			this.txtBankName.Name = "txtBankName";
			this.txtBankName.Size = new System.Drawing.Size(427, 26);
			this.txtBankName.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(3, 32);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 20);
			this.label16.TabIndex = 5;
			this.label16.Text = "БИК";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(3, 64);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(46, 20);
			this.label17.TabIndex = 7;
			this.label17.Text = "Банк";
			// 
			// txtBIK
			// 
			this.txtBIK.Location = new System.Drawing.Point(159, 35);
			this.txtBIK.Name = "txtBIK";
			this.txtBIK.Size = new System.Drawing.Size(427, 26);
			this.txtBIK.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Кор счет";
			// 
			// txtCorrAcc
			// 
			this.txtCorrAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCorrAcc.Location = new System.Drawing.Point(159, 99);
			this.txtCorrAcc.Name = "txtCorrAcc";
			this.txtCorrAcc.Size = new System.Drawing.Size(427, 26);
			this.txtCorrAcc.TabIndex = 9;
			// 
			// BankPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.groupBox4);
			this.Name = "BankPanel";
			this.Size = new System.Drawing.Size(607, 217);
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox4;
		private AcceptCancelPanel acceptCancelPanelBank;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtBankAccount;
		private System.Windows.Forms.TextBox txtBankName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtBIK;
		private System.Windows.Forms.TextBox txtCorrAcc;
		private System.Windows.Forms.Label label1;
	}
}
