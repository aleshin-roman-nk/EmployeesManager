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
	public interface IAddressPanel
	{
		void Bind(BindingSource bs);
		void Unbind();
		event Action<UIEmployee> Store;
	}
	public partial class AddressPanel : UserControl, IAddressPanel
	{
		BindingSource bsMain;
		Address editableObject = null;
		UIEmployee currentObject = null;

		public AddressPanel()
		{
			InitializeComponent();
			ViewMode(true);
		}

		public event Action<UIEmployee> Store;
		private void ViewMode(bool f)
		{
			txtApt.ReadOnly = f;
			txtBuilding.ReadOnly = f;
			txtCity.ReadOnly = f;
			txtPostcode.ReadOnly = f;
			txtStreet.ReadOnly = f;
		}
		public void Bind(BindingSource bs)
		{
			bsMain = bs;
			bsMain.CurrentItemChanged += BsMain_CurrentItemChanged;
			clearBinding();
		}
		void clearBinding()
		{
			txtApt.DataBindings.Clear();
			txtBuilding.DataBindings.Clear();
			txtCity.DataBindings.Clear();
			txtPostcode.DataBindings.Clear();
			txtStreet.DataBindings.Clear();
		}
		private void BsMain_CurrentItemChanged(object sender, EventArgs e)
		{
			setText((bsMain.Current as UIEmployee).Address);
		}
		private void setText(Address addr)
		{
			txtApt.Text = addr.Apartment;
			txtBuilding.Text = addr.Building;
			txtCity.Text = addr.City;
			txtPostcode.Text = addr.Postcode;
			txtStreet.Text = addr.Street;
		}
		void bindEditStart()
		{
			clearBinding();

			currentObject = bsMain.Current as UIEmployee;
			editableObject = currentObject.Address.Clone();

			txtApt.DataBindings.Add("Text", editableObject, "Apartment");
			txtBuilding.DataBindings.Add("Text", editableObject, "Building");
			txtCity.DataBindings.Add("Text", editableObject, "City");
			txtPostcode.DataBindings.Add("Text", editableObject, "Postcode");
			txtStreet.DataBindings.Add("Text", editableObject, "Street");
		}
		void bindEditStop()
		{
			clearBinding();
			editableObject = null;
			currentObject = null;
		}
		private void acceptCancelPanelAddress_Accept()
		{
			ViewMode(true);
			currentObject.Address.Accept(editableObject);
			Store?.Invoke(currentObject);
			bindEditStop();
		}

		private void acceptCancelPanelAddress_Cancel()
		{
			ViewMode(true);
			bindEditStop();
		}

		private void acceptCancelPanelAddress_Edit()
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
