namespace EmployeesEditor.Controls
{
	partial class AddressPanel
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.acceptCancelPanelAddress = new EmployeesEditor.Controls.AcceptCancelPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.txtApt = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPostcode = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtBuilding = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.acceptCancelPanelAddress);
			this.groupBox3.Controls.Add(this.tableLayoutPanel3);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(601, 245);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Адрес";
			// 
			// acceptCancelPanelAddress
			// 
			this.acceptCancelPanelAddress.Location = new System.Drawing.Point(265, 198);
			this.acceptCancelPanelAddress.Name = "acceptCancelPanelAddress";
			this.acceptCancelPanelAddress.Size = new System.Drawing.Size(336, 47);
			this.acceptCancelPanelAddress.TabIndex = 15;
			this.acceptCancelPanelAddress.Edit += new System.Action(this.acceptCancelPanelAddress_Edit);
			this.acceptCancelPanelAddress.Cancel += new System.Action(this.acceptCancelPanelAddress_Cancel);
			this.acceptCancelPanelAddress.Accept += new System.Action(this.acceptCancelPanelAddress_Accept);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48557F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51443F));
			this.tableLayoutPanel3.Controls.Add(this.txtApt, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.label13, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.txtCity, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtPostcode, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtStreet, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.txtBuilding, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 27);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(589, 165);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// txtApt
			// 
			this.txtApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtApt.Location = new System.Drawing.Point(159, 132);
			this.txtApt.Name = "txtApt";
			this.txtApt.Size = new System.Drawing.Size(427, 26);
			this.txtApt.TabIndex = 13;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(3, 129);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 20);
			this.label13.TabIndex = 12;
			this.label13.Text = "Квартира";
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCity.Location = new System.Drawing.Point(159, 35);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(427, 26);
			this.txtCity.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "Индекс";
			// 
			// txtPostcode
			// 
			this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPostcode.Location = new System.Drawing.Point(159, 3);
			this.txtPostcode.Name = "txtPostcode";
			this.txtPostcode.Size = new System.Drawing.Size(427, 26);
			this.txtPostcode.TabIndex = 10;
			// 
			// txtStreet
			// 
			this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtStreet.Location = new System.Drawing.Point(159, 67);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(427, 26);
			this.txtStreet.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(3, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 20);
			this.label10.TabIndex = 5;
			this.label10.Text = "Город";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(3, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 20);
			this.label11.TabIndex = 7;
			this.label11.Text = "Улица";
			// 
			// txtBuilding
			// 
			this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBuilding.Location = new System.Drawing.Point(159, 99);
			this.txtBuilding.Name = "txtBuilding";
			this.txtBuilding.Size = new System.Drawing.Size(427, 26);
			this.txtBuilding.TabIndex = 12;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(3, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 20);
			this.label12.TabIndex = 11;
			this.label12.Text = "Дом";
			// 
			// AddressPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.groupBox3);
			this.Name = "AddressPanel";
			this.Size = new System.Drawing.Size(608, 249);
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private AcceptCancelPanel acceptCancelPanelAddress;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox txtApt;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPostcode;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtBuilding;
		private System.Windows.Forms.Label label12;
	}
}
