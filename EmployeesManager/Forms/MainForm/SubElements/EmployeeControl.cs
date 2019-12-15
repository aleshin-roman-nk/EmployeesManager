using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager.Forms.MainForm.SubElements
{
	public interface IEmployeeControl
	{
		string EmployeeName { get; set; }
	}

	public partial class EmployeeControl : UserControl, IEmployeeControl
	{
		public EmployeeControl()
		{
			InitializeComponent();
		}

		public string EmployeeName
		{
			get { return label1.Text; }
			set { label1.Text = value; }
		}
	}
}
