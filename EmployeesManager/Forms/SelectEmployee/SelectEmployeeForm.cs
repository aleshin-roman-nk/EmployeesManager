using DrRomic.UI;
using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager.Forms.SelectEmployee
{
	public interface ISelectEmployeeForm
	{
		void SetEmployees(IEnumerable<Employee> empls);
		Employee GetEmployee();
		IEnumerable<Employee> GetEmployees();
	}

	public partial class SelectEmployeeForm : Form, ISelectEmployeeForm
	{
		BindingSource bsMain;
		GridPanel gridPanel;

		public SelectEmployeeForm()
		{
			InitializeComponent();

			bsMain = new BindingSource();
			gridPanel = new GridPanel(dgvMain);
			gridPanel.Attach(bsMain, DocumentColumns);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		public void SetEmployees(IEnumerable<Employee> empls)
		{
			bsMain.DataSource = empls;
			bsMain.ResetBindings(false);
		}

		public Employee GetEmployee()
		{
			var res = this.ShowDialog();

			return res == DialogResult.OK ? bsMain.Current as Employee : null;
		}

		private IEnumerable<GridPanelColumn> DocumentColumns
		{
			get
			{
				List<GridPanelColumn> c = new List<GridPanelColumn>();

				c.Add(new GridPanelColumn("Ф.И.О.", "FullName", "col1", 300));

				return c;
			}
		}

		private void dgvMain_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				DialogResult = DialogResult.OK;
				e.Handled = true;
			}
		}

		public IEnumerable<Employee> GetEmployees()
		{
			var res = this.ShowDialog();

			var items = dgvMain.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Employee);

			return res == DialogResult.OK ? items : null;
		}
	}
}
