using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEditor.Controls
{
	public interface IAcceptCancelPanel
	{
		event Action Edit;
		event Action Cancel;
		event Action Accept;
	}
	public partial class AcceptCancelPanel : UserControl, IAcceptCancelPanel
	{
		public AcceptCancelPanel()
		{
			InitializeComponent();

			btnAccept.Enabled = false;
			btnCancel.Enabled = false;
		}

		public event Action Edit;
		public event Action Cancel;
		public event Action Accept;

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Edit?.Invoke();
			btnEdit.Enabled = false;
			btnAccept.Enabled = true;
			btnCancel.Enabled = true;
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			Accept?.Invoke();
			btnEdit.Enabled = true;
			btnAccept.Enabled = false;
			btnCancel.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Cancel?.Invoke();
			btnEdit.Enabled = true;
			btnAccept.Enabled = false;
			btnCancel.Enabled = false;
		}
	}
}
