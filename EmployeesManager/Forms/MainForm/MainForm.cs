using DrRomic.UI;
using EmModel.Entities;
using EmModel.Entities.UI;
using EmployeesManager.Forms.Dialogs;
using EmployeesManager.Forms.SelectEmployee;
using EmployeesManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
	public partial class MainForm : Form, IMainView
	{
		BindingSource bsGridDocuments = new BindingSource();
		BindingSource bsGridWorks = new BindingSource();
		GridPanel smartGrid;

		public event Action BtnCreateDocument;
		public event Action DateChanged;
		public event Action EmployeeSelected;
		public event Action<WorkDocument> BtnCreateWork;
		public event Action<Work> BtnEditWork;
		public event Action<WorkDocument> BtnDeleteDocument;
		public event Action<Work> BtnDeleteWork;
		public event Action<IEnumerable<WorkDocument>> BtnMakePayment;

		public MainForm()
		{
			InitializeComponent();

			smartGrid = new GridPanel(gridMain);
			Text = dateTimePicker1.Value.ToString("yy.MMMM");
			bsGridDocuments.CurrentItemChanged += BsGrid_CurrentItemChanged;
		}

		private void BsGrid_CurrentItemChanged(object sender, EventArgs e)
		{
			if (bsGridDocuments.Current == null) return;

			EmployeeSelected?.Invoke();
			txtEmployeeFIO.Text = (bsGridDocuments.Current as WorkDocument).Title;
		}

		public void ShowMsg(string msg)
		{
			MessageBox.Show(msg);
		}

		public string DlgInputString
		{
			get
			{
				IInputStringDlg dlg = new InputStringDlg();
				var r = dlg.ShowDlg();
				return r == DialogResult.OK ? dlg.InputString : null;
			}
		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateChanged?.Invoke();
			Text = dateTimePicker1.Value.ToString("yy.MMMM");
		}

		private void btnCreateDocument_Click(object sender, EventArgs e)
		{
			BtnCreateDocument?.Invoke();
		}

        public void SetDocuments(IEnumerable<WorkDocument> docs)
        {
			bsGridDocuments.DataSource = docs;
			bsGridWorks.DataSource = bsGridDocuments;
			bsGridWorks.DataMember = "Works";

			gridWorks.DataSource = bsGridWorks;

			smartGrid.DetachAll();
			smartGrid.Attach(bsGridDocuments, DocumentColumns);
		}
		public Employee ChooseEmployee(IEnumerable<Employee> empls)
		{
			ISelectEmployeeForm form = new SelectEmployeeForm();

			form.SetEmployees(empls);
			return form.GetEmployee();
		}
		public IEnumerable<Employee> ChooseEmployees(IEnumerable<Employee> empls)
		{
			ISelectEmployeeForm form = new SelectEmployeeForm();

			form.SetEmployees(empls);
			return form.GetEmployees();
		}

		public void SetWorks(IEnumerable<Work> works)
		{
			bsGridWorks.DataSource = works;

			smartGrid.DetachAll();
			smartGrid.Attach(bsGridDocuments, DocumentColumns);
		}
		public IEnumerable<GridPanelColumn> DocumentColumns
		{
			get
			{
				List<GridPanelColumn> c = new List<GridPanelColumn>();

				c.Add(new GridPanelColumn("Документ", "Title", "col1", 400));
				c.Add(new GridPanelColumn("Сумма", "TotalSum", "col2", 100));
				c.Add(new GridPanelColumn("Оплачено", "PayDocMaked", "col3", 100));

				return c;
			}
		}
		public IEnumerable<GridPanelColumn> WorkColumns
		{
			get
			{
				List<GridPanelColumn> c = new List<GridPanelColumn>();

				c.Add(new GridPanelColumn("Работа", "Name", "col1", 400));

				return c;
			}
		}
		public DateTime Date => dateTimePicker1.Value;
		public Work CurrentWork => bsGridWorks.Current as Work;
		public WorkDocument CurrentWorkDocument => bsGridDocuments.Current as WorkDocument;

		public IEnumerable<WorkDocument> SelectedDocuments
		{
			get
			{
				return gridMain.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as WorkDocument);
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			BtnCreateWork?.Invoke(bsGridDocuments.Current as WorkDocument);
		}

		private void btnCreateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BtnCreateDocument?.Invoke();
		}

		private void btnDeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BtnDeleteDocument?.Invoke(CurrentWorkDocument);
		}

		private void gridMain_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				BtnDeleteDocument?.Invoke(CurrentWorkDocument);
				e.Handled = true;
				return;
			}
			if(e.KeyCode == Keys.Insert)
			{
				BtnCreateDocument?.Invoke();
				e.Handled = true;
				return;
			}
			if(e.KeyCode == Keys.Enter)
			{
				BtnCreateWork?.Invoke(CurrentWorkDocument);
				e.Handled = true;
				return;
			}
		}

		public bool UserAnswerYes(string msg)
		{
			return MessageBox.Show(msg, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
		}

		private void gridWorks_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnEditWork?.Invoke(CurrentWork);
				e.Handled = true;
				return;
			}
			if(e.KeyCode == Keys.Delete)
			{
				BtnDeleteWork?.Invoke(CurrentWork);
				e.Handled = true;
				return;
			}
			if(e.KeyCode == Keys.Insert)
			{
				BtnCreateWork?.Invoke(CurrentWorkDocument);
				e.Handled = true;
				return;
			}
		}

		private void btnPaySelected_Click(object sender, EventArgs e)
		{
			BtnMakePayment?.Invoke(SelectedDocuments);
		}

		public string GetFileName()
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "txt files (*.txt)|*.txt";

				return DialogResult.OK == sfd.ShowDialog() ? sfd.FileName : null;
			}
		}
	}
}
