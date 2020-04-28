using EmModel.Entities;
using EmModel.Entities.UI;
using EmployeesManager.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Views
{
	public interface IMainView
	{
		event Action BtnCreateDocument;
		event Action<WorkDocument> BtnCreateWork;
		event Action<Work> BtnEditWork;
		event Action<WorkDocument> BtnDeleteDocument;
		event Action<Work> BtnDeleteWork;
		event Action<IEnumerable<WorkDocument>> BtnMakePayment;
		event Action DateChanged;
		event Action EmployeeSelected;
		string DlgInputString { get; }
		void ShowMsg(string msg);
        void SetDocuments(IEnumerable<WorkDocument> docs);
		void SetWorks(IEnumerable<Work> works);
		Employee ChooseEmployee(IEnumerable<Employee> empls);
		IEnumerable<Employee> ChooseEmployees(IEnumerable<Employee> empls);
		Work EditWork(Work src);
		string GetFileName();
		Work CurrentWork { get; }
		WorkDocument CurrentWorkDocument { get; }
		IEnumerable<WorkDocument> SelectedDocuments { get; }
		DateTime Date { get; }
		bool UserAnswerYes(string msg);
	}
}
