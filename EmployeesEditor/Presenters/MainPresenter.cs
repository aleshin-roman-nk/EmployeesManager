using EmModel.Models;
using EmployeesEditor.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesEditor.Presenters
{
	public class MainPresenter
	{
		UIEmployeesModel employeesModel;
		IMainView mainView;

		public MainPresenter(IMainView v)
		{
			mainView = v;
			employeesModel = new UIEmployeesModel();

			mainView.CreateEmployee += MainView_CreateEmployee;
			mainView.StoreEmployee += MainView_StoreEmployee;
			mainView.SetEmployees(employeesModel.GetUIEmployees());
			mainView.GenerateContracts += MainView_GenerateContracts;
			mainView.RemoveEmployee += MainView_RemoveEmployee;
		}

		private void MainView_RemoveEmployee(EmModel.Entities.UI.UIEmployee obj)
		{
			if (!mainView.UserAnswerYes($"Сотрудник {obj.FullName} будет удален навсегда. Вы уверены?", "УДАЛЕНИЕ СОТРУДНИКА")) return;

			employeesModel.RemoveEmployee(obj);
			mainView.SetEmployees(employeesModel.GetUIEmployees());
		}

		private void MainView_GenerateContracts(IEnumerable<EmModel.Entities.UI.UIEmployee> obj)
		{
			string tmpl = File.ReadAllText(@"..\..\..\db\contract.htmltemplate", Encoding.UTF8);

			string outfile = employeesModel.GenerateContracts(obj, tmpl);

			File.WriteAllText("contracts.html", outfile, Encoding.UTF8);
		}

		private void MainView_StoreEmployee(EmModel.Entities.UI.UIEmployee obj)
		{
			employeesModel.StoreEmployee(obj);
			mainView.SetEmployees(employeesModel.GetUIEmployees());
		}

		private void MainView_CreateEmployee()
		{
			try
			{
				var o = employeesModel.CreateEmployee();
				employeesModel.StoreEmployee(o);
				mainView.SetEmployees(employeesModel.GetUIEmployees());
			}
			catch (Exception ex)
			{
				mainView.Msg(ex.Message);
			}
		}
	}
}
