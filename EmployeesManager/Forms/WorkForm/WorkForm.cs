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

namespace EmployeesManager.Forms.WorkForm
{
	public interface IWorkForm
	{
		void SetWork(Work work);
		Work GetWork();
	}

	public partial class WorkForm : Form, IWorkForm
	{
		Work work;

		public WorkForm()
		{
			InitializeComponent();
		}
		public Work GetWork()
		{
			this.ShowDialog();
			return DialogResult == DialogResult.OK ? work : null;
		}
		public void SetWork(Work w)
		{
			Bind(w);
		}
		protected void Bind(Work w)
		{
			work = w;

			txtCount.DataBindings.Add("Text", w, "Count");
			txtDescription.DataBindings.Add("Text", w, "Description");
			txtPrice.DataBindings.Add("Text", w, "Price");
			txtWorkName.DataBindings.Add("Text", w, "Name");
			txtSum.DataBindings.Add("Text", w, "Sum");
		}
		//private void txtValormetrocubico_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	if (!char.IsControl(e.KeyChar)
		//			&& !char.IsDigit(e.KeyChar)
		//			&& e.KeyChar != '.' && e.KeyChar != ',')
		//	{
		//		e.Handled = true;
		//	}

		//	//check if '.' , ',' pressed
		//	char sepratorChar = 's';
		//	if (e.KeyChar == '.' || e.KeyChar == ',')
		//	{
		//		// check if it's in the beginning of text not accept
		//		if (txtPrice.Text.Length == 0) e.Handled = true;
		//		// check if it's in the beginning of text not accept
		//		if (txtPrice.SelectionStart == 0) e.Handled = true;
		//		// check if there is already exist a '.' , ','
		//		if (alreadyExist(txtPrice.Text, ref sepratorChar)) e.Handled = true;
		//		//check if '.' or ',' is in middle of a number and after it is not a number greater than 99
		//		if (txtPrice.SelectionStart != txtPrice.Text.Length && e.Handled == false)
		//		{
		//			// '.' or ',' is in the middle
		//			string AfterDotString = txtPrice.Text.Substring(txtPrice.SelectionStart);

		//			if (AfterDotString.Length > 2)
		//			{
		//				e.Handled = true;
		//			}
		//		}
		//	}
		//	//check if a number pressed

		//	if (Char.IsDigit(e.KeyChar))
		//	{
		//		//check if a coma or dot exist
		//		if (alreadyExist(txtPrice.Text, ref sepratorChar))
		//		{
		//			int sepratorPosition = txtPrice.Text.IndexOf(sepratorChar);
		//			string afterSepratorString = txtPrice.Text.Substring(sepratorPosition + 1);
		//			if (txtPrice.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
		//			{
		//				e.Handled = true;
		//			}

		//		}
		//	}
		//}
		//private bool alreadyExist(string _text, ref char KeyChar)
		//{
		//	if (_text.IndexOf('.') > -1)
		//	{
		//		KeyChar = '.';
		//		return true;
		//	}
		//	if (_text.IndexOf(',') > -1)
		//	{
		//		KeyChar = ',';
		//		return true;
		//	}
		//	return false;
		//}
	}
}
