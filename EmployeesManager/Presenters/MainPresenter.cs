using EmModel.Entities;
using EmModel.Models;
using EmployeesManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Presenters
{
	public class MainPresenter
	{
		IMainView view;
		EmployeesModel model;
		YearsModel yearsModel;
		MonthsModel monthsModel;

		public MainPresenter(IMainView v)
		{
			view = v;
			model = new EmployeesModel();
			yearsModel = new YearsModel();
			monthsModel = new MonthsModel();

			//view.SetEmployees(model.GetUIEmployees());
			view.SetYears(yearsModel.Years, yearsModel.CurrentYear);
			view.SetCurrentTitle(yearsModel.CurrentYear.Name);

			// Презентер подписывается (прослушивать) на запросы-события от view
			view.UserCreatesYear += View_UserCreatesYear;
			view.MonthSelected += View_MonthSelected;
			view.YearSelected += View_YearSelected;
			view.LevelChanged += View_LevelChanged;
		}

		private void View_LevelChanged(Level obj)
		{
			// Мой стиль кода - этот участок долеж в специальном методе быть, для порядка кода
			switch (obj)
			{
				case Level.Years:
					view.SetYears(yearsModel.Years, yearsModel.CurrentYear);
					break;
				case Level.Months:
					view.SetMonths(monthsModel.GetMonths(yearsModel.CurrentYear), monthsModel.CurrentMonth);
					break;
				case Level.WorkDocuments:
					break;
				case Level.Works:
					break;
				default:
					break;
			}
		}

		private void View_YearSelected(Year obj)
		{
			yearsModel.CurrentYear = obj;
			view.SetCurrentTitle(yearsModel.CurrentYear.Name);
		}

		private void View_MonthSelected(Month obj)
		{
			monthsModel.CurrentMonth = obj;
			view.SetCurrentTitle($"{yearsModel.CurrentYear.Name} / {obj.Name}");
		}

		// We need an other model that contains information what an year, a month current is.
		// Может загрузить сразу всю структуру
		//		Year.Month
		//	А документы и работы документов подгружать по запросу.
		// А может просто папки. Элемент-папка.
		//		В этой папке что то содержится.
		//
		// >>>
		// А можно запрашивать дай всех детей объекта Х
		//		или дай родителя объекта Y

		private void View_UserCreatesYear()
		{
			var str = view.DlgInputString;
			if(str != null)
			{
				try
				{
					yearsModel.CreateYear(str);
					view.SetYears(yearsModel.Years, yearsModel.CurrentYear);
				}
				catch (Exception ex)
				{
					view.ShowMsg(ex.Message);
				}
			}
		}
	}
}
