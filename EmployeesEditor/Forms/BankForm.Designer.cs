namespace EmployeesEditor.Forms
{
	partial class BankForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtBankName = new System.Windows.Forms.TextBox();
			this.txtBankBIK = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCorrAcc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Наименование";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(282, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtBankName
			// 
			this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBankName.Location = new System.Drawing.Point(12, 188);
			this.txtBankName.Name = "txtBankName";
			this.txtBankName.Size = new System.Drawing.Size(282, 26);
			this.txtBankName.TabIndex = 2;
			// 
			// txtBankBIK
			// 
			this.txtBankBIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBankBIK.Location = new System.Drawing.Point(12, 240);
			this.txtBankBIK.Name = "txtBankBIK";
			this.txtBankBIK.Size = new System.Drawing.Size(282, 26);
			this.txtBankBIK.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "БИК";
			// 
			// txtCorrAcc
			// 
			this.txtCorrAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCorrAcc.Location = new System.Drawing.Point(12, 292);
			this.txtCorrAcc.Name = "txtCorrAcc";
			this.txtCorrAcc.Size = new System.Drawing.Size(282, 26);
			this.txtCorrAcc.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Корр счет";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(210, 324);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(84, 23);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "Добавить";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// BankForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 449);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtCorrAcc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBankBIK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBankName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "BankForm";
			this.Text = "BankForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtBankName;
		private System.Windows.Forms.TextBox txtBankBIK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCorrAcc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCreate;
	}
}