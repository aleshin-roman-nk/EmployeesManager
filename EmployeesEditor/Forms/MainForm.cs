using EmModel.Entities;
using EmModel.Entities.UI;
using EmployeesEditor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEditor
{
	public partial class MainForm : Form, IMainView
	{
		BindingSource bsEmployees;

		public MainForm()
		{
			InitializeComponent();

			bsEmployees = new BindingSource();
			gridEmployee.DataSource = bsEmployees;

			txtFIO.DataBindings.Add("Text", bsEmployees, "FullName");

			ipPanel1.Bind(bsEmployees);
			fioPanel1.Bind(bsEmployees);
			passportPanel1.Bind(bsEmployees);
			addressPanel1.Bind(bsEmployees);
			bankPanel1.Bind(bsEmployees);
		}

		public event Action CreateEmployee;
		public event Action<UIEmployee> StoreEmployee;
		public event Action<IEnumerable<UIEmployee>> GenerateContracts;
		public event Action<UIEmployee> RemoveEmployee;

		public void Msg(string str)
		{
			MessageBox.Show(str);
		}

		private void CreateEmployee_Click(object sender, EventArgs e)
		{
			CreateEmployee?.Invoke();
		}

		public void SetEmployees(IEnumerable<UIEmployee> empls)
		{
			ipPanel1.Unbind();
			fioPanel1.Unbind();
			passportPanel1.Unbind();

			bsEmployees.DataSource = empls;

			ipPanel1.Bind(bsEmployees);
			fioPanel1.Bind(bsEmployees);
			passportPanel1.Bind(bsEmployees);

			bsEmployees.ResetBindings(false);
		}
		private void fioPanel1_Store(UIEmployee obj)
		{
			StoreEmployee?.Invoke(obj);
		}

		private void ipPanel1_Store(UIEmployee obj)
		{
			StoreEmployee?.Invoke(obj);
		}

		private void passportPanel1_Store(UIEmployee obj)
		{
			StoreEmployee?.Invoke(obj);
		}

		private void addressPanel1_Store(UIEmployee obj)
		{
			StoreEmployee?.Invoke(obj);
		}

		private void bankPanel1_Store_1(UIEmployee obj)
		{
			StoreEmployee?.Invoke(obj);
		}

		private void btnGenerateContracts_Click(object sender, EventArgs e)
		{
			List<UIEmployee> col = new List<UIEmployee>();

			foreach (DataGridViewCell cell in gridEmployee.SelectedCells)
			{
				var o = cell.OwningRow.DataBoundItem as UIEmployee;
				col.Add(o);
			} 

			GenerateContracts?.Invoke(col);
		}
		private void btnRemoveEmployee_Click(object sender, EventArgs e)
		{
			RemoveEmployee?.Invoke(bsEmployees.Current as UIEmployee);
		}
		public bool UserAnswerYes(string msg, string warning)
		{
			return MessageBox.Show(msg, warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
		}
	}
}
