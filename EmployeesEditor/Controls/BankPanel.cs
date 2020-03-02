using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmModel.Entities.UI;
using EmModel.Entities;

namespace EmployeesEditor.Controls
{
	public interface IBankPanel
	{
		void Bind(BindingSource bs);
		void Unbind();
		event Action<UIEmployee> Store;
	}
	public partial class BankPanel : UserControl, IBankPanel
	{
		BindingSource bsMain;
		BankAcc editableObject = null;
		UIEmployee currentObject = null;

		public BankPanel()
		{
			InitializeComponent();
			ViewMode(true);
		}

		public event Action<UIEmployee> Store;

		public void Bind(BindingSource bs)
		{
			bsMain = bs;
			bsMain.CurrentItemChanged += BsMain_CurrentItemChanged;
			clearBinding();
		}
		private void BsMain_CurrentItemChanged(object sender, EventArgs e)
		{
			setText((bsMain.Current as UIEmployee).BankAcc);
		}
		public void Unbind()
		{
			txtBankName.DataBindings.Clear();
			txtCorrAcc.DataBindings.Clear();
			txtBankAccount.DataBindings.Clear();
			txtBIK.DataBindings.Clear();

			bsMain.CurrentItemChanged -= BsMain_CurrentItemChanged;
		}
		void clearBinding()
		{
			txtBankAccount.DataBindings.Clear();
			txtBankName.DataBindings.Clear();
			txtBIK.DataBindings.Clear();
			txtCorrAcc.DataBindings.Clear();
		}
		void bindEditStart()
		{
			txtBankAccount.DataBindings.Clear();
			txtBankName.DataBindings.Clear();
			txtBIK.DataBindings.Clear();
			txtCorrAcc.DataBindings.Clear();

			currentObject = bsMain.Current as UIEmployee;
			editableObject = currentObject.BankAcc.Clone();

			txtBankAccount.DataBindings.Add("Text", editableObject, "Accaunt");
			txtBankName.DataBindings.Add("Text", editableObject, "BankName");
			txtBIK.DataBindings.Add("Text", editableObject, "BIK");
			txtCorrAcc.DataBindings.Add("Text", editableObject, "BankCorrAcc");
		}
		void bindEditStop()
		{
			clearBinding();
			editableObject = null;
			currentObject = null;
		}
		private void ViewMode(bool f)
		{
			txtBankName.ReadOnly = f;
			txtCorrAcc.ReadOnly = f;
			txtBankAccount.ReadOnly = f;
			txtBIK.ReadOnly = f;
		}
		private void setText(BankAcc bnk)
		{
			txtBankName.Text = bnk.BankName;
			txtCorrAcc.Text = bnk.BankCorrAcc;
			txtBankAccount.Text = bnk.Accaunt;
			txtBIK.Text = bnk.BIK;
		}
		private void acceptCancelPanelBank_Accept()
		{
			ViewMode(true);
			currentObject.BankAcc.Accept(editableObject);
			Store?.Invoke(currentObject);
			bindEditStop();
		}

		private void acceptCancelPanelBank_Cancel()
		{
			ViewMode(true);
			bindEditStop();
		}

		private void acceptCancelPanelBank_Edit()
		{
			ViewMode(false);
			bindEditStart();
		}
	}
}
