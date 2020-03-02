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
	public interface IPassportPanel
	{
		void Bind(BindingSource bs);
		void Unbind();
		event Action<UIEmployee> Store;
	}
	public partial class PassportPanel : UserControl, IPassportPanel
	{
		BindingSource bsMain;
		Passport editableObject = null;
		UIEmployee currentObject = null;

		public PassportPanel()
		{
			InitializeComponent();
			ViewMode(true);
		}

		public event Action<UIEmployee> Store;
		private void ViewMode(bool f)
		{
			txtBornDate.Enabled = !f;
			txtIssuedDate.Enabled = !f;
			txtPassportIssuedBy.ReadOnly = f;
			txtPassportNumber.ReadOnly = f;
		}
		public void Bind(BindingSource bs)
		{
			bsMain = bs;
			bsMain.CurrentItemChanged += BsMain_CurrentItemChanged;
			clearBinding();
		}

		private void BsMain_CurrentItemChanged(object sender, EventArgs e)
		{
			setText((bsMain.Current as UIEmployee).Passport);
		}

		private void setText(Passport psp)
		{
			txtBornDate.Value = psp.BornDay;
			txtIssuedDate.Value = psp.PassportDate;
			txtPassportIssuedBy.Text = psp.IssuedBy;
			txtPassportNumber.Text = psp.SerialNumber;
		}

		void clearBinding()
		{
			txtBornDate.DataBindings.Clear();
			txtIssuedDate.DataBindings.Clear();
			txtPassportIssuedBy.DataBindings.Clear();
			txtPassportNumber.DataBindings.Clear();
		}
		void bindEditStart()
		{
			txtBornDate.DataBindings.Clear();
			txtIssuedDate.DataBindings.Clear();
			txtPassportIssuedBy.DataBindings.Clear();
			txtPassportNumber.DataBindings.Clear();

			currentObject = bsMain.Current as UIEmployee;
			editableObject = currentObject.Passport.Clone();

			txtBornDate.DataBindings.Add("Value", editableObject, "BornDay");
			txtIssuedDate.DataBindings.Add("Value", editableObject, "PassportDate");
			txtPassportIssuedBy.DataBindings.Add("Text", editableObject, "IssuedBy");
			txtPassportNumber.DataBindings.Add("Text", editableObject, "SerialNumber");
		}
		void bindEditStop()
		{
			clearBinding();
			editableObject = null;
			currentObject = null;
		}

		private void acceptCancelPanelPassport_Accept()
		{
			ViewMode(true);
			currentObject.Passport.Accept(editableObject);
			Store?.Invoke(currentObject);
			bindEditStop();
		}

		private void acceptCancelPanelPassport_Cancel()
		{
			ViewMode(true);
			bindEditStop();
		}

		private void acceptCancelPanelPassport_Edit()
		{
			ViewMode(false);
			bindEditStart();
		}

		public void Unbind()
		{
			txtBornDate.DataBindings.Clear();
			txtIssuedDate.DataBindings.Clear();
			txtPassportIssuedBy.DataBindings.Clear();
			txtPassportNumber.DataBindings.Clear();

			bsMain.CurrentItemChanged -= BsMain_CurrentItemChanged;
		}
	}
}
