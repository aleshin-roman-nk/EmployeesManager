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
	public interface IIPPanel
	{
		void Bind(BindingSource bs);
		void Unbind();
		event Action<UIEmployee> Store;
	}
	public partial class IPPanel : UserControl, IIPPanel
	{
		BindingSource bsMain;
		Business editableObject = null;
		UIEmployee currentObject = null;
		public IPPanel()
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
			setText((bsMain.Current as UIEmployee).Business);
		}
		private void setText(Business bs)
		{
			txtINN.Text = bs.INN;
			txtOGRNIP.Text = bs.OGRNIP;
			txtOGRNIPDate.Value = bs.OGRNIP_DATE;
			txtOGRNIPIssuedBy.Text = bs.OGRNIPIssuedBy;
			txtContractDate.Value = bs.ContractDate;
			txtContractDateEnd.Text = bs.ContractDateEnd.ToString("dd-MM-yyyy");
			txtContractDuring.Text = bs.ContractDuring.ToString();
			txtContractNo.Text = bs.ContractNo;
		}
		void clearBinding()
		{
			txtINN.DataBindings.Clear();
			txtOGRNIP.DataBindings.Clear();
			txtOGRNIPDate.DataBindings.Clear();
			txtOGRNIPIssuedBy.DataBindings.Clear();
			txtContractDate.DataBindings.Clear();
			txtContractDateEnd.DataBindings.Clear();
			txtContractDuring.DataBindings.Clear();
			txtContractNo.DataBindings.Clear();
		}
		void bindEditStart()
		{
			clearBinding();

			currentObject = bsMain.Current as UIEmployee;
			editableObject = currentObject.Business.Clone();

			txtINN.DataBindings.Add("Text", editableObject, "INN"); 
			txtOGRNIP.DataBindings.Add("Text", editableObject, "OGRNIP");
			txtOGRNIPDate.DataBindings.Add("Value", editableObject, "OGRNIP_DATE");
			txtOGRNIPIssuedBy.DataBindings.Add("Text", editableObject, "OGRNIPIssuedBy");

			txtContractDate.DataBindings.Add("Value", editableObject, "ContractDate");
			txtContractDateEnd.DataBindings.Add("Text", editableObject, "ContractDateEnd");
			txtContractDuring.DataBindings.Add("Text", editableObject, "ContractDuring");
			txtContractNo.DataBindings.Add("Text", editableObject, "ContractNo");
		}
		void bindEditStop()
		{
			clearBinding();
			editableObject = null;
			currentObject = null;
		}
		private void ViewMode(bool f)
		{
			txtINN.ReadOnly = txtOGRNIP.ReadOnly = txtOGRNIPIssuedBy.ReadOnly = f;
			txtOGRNIPDate.Enabled = !f;

			txtContractDate.Enabled = !f;
			txtContractDateEnd.ReadOnly = true;
			txtContractDuring.ReadOnly = f;
			txtContractNo.ReadOnly = f;
		}
		private void acceptCancelPanelIP_Accept()
		{
			ViewMode(true);
			currentObject.Business.Accept(editableObject);
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
			clearBinding();
			bsMain.CurrentItemChanged -= BsMain_CurrentItemChanged;
		}
	}
}
