namespace EmployeesManager.Forms.WorkForm
{
	partial class WorkForm
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
			this.txtWorkName = new System.Windows.Forms.TextBox();
			this.btnChangePosition = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.txtSum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Наименование";
			// 
			// txtWorkName
			// 
			this.txtWorkName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtWorkName.Location = new System.Drawing.Point(133, 6);
			this.txtWorkName.Name = "txtWorkName";
			this.txtWorkName.Size = new System.Drawing.Size(432, 27);
			this.txtWorkName.TabIndex = 1;
			// 
			// btnChangePosition
			// 
			this.btnChangePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChangePosition.Location = new System.Drawing.Point(571, 6);
			this.btnChangePosition.Name = "btnChangePosition";
			this.btnChangePosition.Size = new System.Drawing.Size(32, 27);
			this.btnChangePosition.TabIndex = 10;
			this.btnChangePosition.TabStop = false;
			this.btnChangePosition.Text = "...";
			this.btnChangePosition.UseVisualStyleBackColor = true;
			this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Стоимость";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Количество";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDescription.Location = new System.Drawing.Point(133, 138);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(432, 75);
			this.txtDescription.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Подробности";
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(323, 219);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(118, 39);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(447, 219);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(118, 39);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 19);
			this.label5.TabIndex = 11;
			this.label5.Text = "Сумма";
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPrice.Location = new System.Drawing.Point(133, 39);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(221, 27);
			this.txtPrice.TabIndex = 2;
			// 
			// txtCount
			// 
			this.txtCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCount.Location = new System.Drawing.Point(133, 72);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(221, 27);
			this.txtCount.TabIndex = 3;
			// 
			// txtSum
			// 
			this.txtSum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSum.Location = new System.Drawing.Point(133, 105);
			this.txtSum.Name = "txtSum";
			this.txtSum.ReadOnly = true;
			this.txtSum.Size = new System.Drawing.Size(221, 27);
			this.txtSum.TabIndex = 14;
			this.txtSum.TabStop = false;
			// 
			// WorkForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(617, 283);
			this.Controls.Add(this.txtSum);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnChangePosition);
			this.Controls.Add(this.txtWorkName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "WorkForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Работа";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWorkName;
		private System.Windows.Forms.Button btnChangePosition;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.TextBox txtSum;
	}
}