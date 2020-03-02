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
	public interface IFIOPanel
	{
		void Bind(BindingSource bs);
		void Unbind();
		event Action<UIEmployee> Store;
	}
	public partial class FIOPanel : UserControl, IFIOPanel
	{
		BindingSource bsMain;
		Employee editableObject = null;
		UIEmployee currentObject = null;

		public event Action<UIEmployee> Store;

		public FIOPanel()
		{
			InitializeComponent();
			ViewMode(true);
		}
		public void Bind(BindingSource bs)
		{
			bsMain = bs;
			bind();
		}
		void bind()
		{
			txtFirstName.DataBindings.Clear();
			txtSecondName.DataBindings.Clear();
			txtThirdName.DataBindings.Clear();

			txtFirstName.DataBindings.Add("Text", bsMain, "Employee.Name");
			txtSecondName.DataBindings.Add("Text", bsMain, "Employee.Surname");
			txtThirdName.DataBindings.Add("Text", bsMain, "Employee.Patronymic");
		}
		void bindEditStart()
		{
			txtFirstName.DataBindings.Clear();
			txtSecondName.DataBindings.Clear();
			txtThirdName.DataBindings.Clear();

			currentObject = bsMain.Current as UIEmployee;
			editableObject = currentObject.Employee.Clone();

			txtFirstName.DataBindings.Add("Text", editableObject, "Name");
			txtSecondName.DataBindings.Add("Text", editableObject, "Surname");
			txtThirdName.DataBindings.Add("Text", editableObject, "Patronymic");
		}
		void bindEditStop()
		{
			bind();
			editableObject = null;
			currentObject = null;
		}
		private void ViewMode(bool f)
		{
			txtFirstName.ReadOnly = txtSecondName.ReadOnly = txtThirdName.ReadOnly = f;
		}
		private void acceptCancelPanelIP_Accept()
		{
			ViewMode(true);
			currentObject.Employee.Accept(editableObject);
			Store?.Invoke(currentObject);
			bindEditStop();
		}
		private void acceptCancelPanelIP_Cancel()
		{
			ViewMode(true);
			bindEditStop();
		}
		private void acceptCancelPanelIP_Edit()
		{
			ViewMode(false);
			bindEditStart();
		}

		public void Unbind()
		{
			txtFirstName.DataBindings.Clear();
			txtSecondName.DataBindings.Clear();
			txtThirdName.DataBindings.Clear();
		}
	}
}
