using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager.Forms.Dialogs
{
	public interface IInputStringDlg
	{
		DialogResult ShowDlg();
		string InputString { get; }
	}

	public partial class InputStringDlg : Form, IInputStringDlg
	{
		public InputStringDlg()
		{
			InitializeComponent();
		}

		public string InputString => txtInputString.Text;

		public DialogResult ShowDlg()
		{
			return this.ShowDialog();
		}
	}
}
