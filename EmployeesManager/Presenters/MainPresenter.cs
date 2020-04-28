using EmModel;
using EmModel.DiscAccess;
using EmModel.Entities;
using EmModel.Models;
using EmployeesManager.Forms.WorkForm;
using EmployeesManager.Views;
using MonthTasksBank;
using PaymentOrder1C;
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
		
		WorkDocumentsModel documentsModel;

		public MainPresenter(IMainView v)
		{
			view = v;
			documentsModel = new WorkDocumentsModel();

			view.BtnCreateDocument += View_BtnCreateDocument;
			view.BtnCreateWork += View_BtnCreateWork;
			view.DateChanged += View_DateChanged;
			view.BtnDeleteDocument += View_BtnDeleteDocument;
			view.BtnEditWork += View_BtnEditWork;
			view.BtnDeleteWork += View_BtnDeleteWork;
			view.BtnMakePayment += View_BtnMakePayment;

			var dt = DateTime.Today;

			try
			{
				view.SetDocuments(documentsModel.GetDocuments(dt.Year, dt.Month));
			}
			catch (Exception ex)
			{
				LOG_CLASS.Log(ex.Message);
			}
		}

		private void View_BtnMakePayment(IEnumerable<WorkDocument> obj)
		{
			if (obj == null) return;

			var docsEx = documentsModel.GetWorkDocumentsEx(obj).ToList();
			if (docsEx.Count == 0)
			{
				view.ShowMsg("Отсутствуют документы, подходящие для оплаты");
				return;
			}

			string fileName = view.GetFileName();
			if (fileName == null) return;
			
			var payer = documentsModel.GetWorkDocumentExByFIO("Алешин Роман Владимирович");

			int startNo = documentsModel.LastDocumentNo;
			int startPayDocNo = documentsModel.LastPayDocNo;
			foreach (var item in obj)
			{
				item.No = ++startNo;
				item.PayDocMaked = true;
			}

			string res = new Builder1C().Build(docsEx, payer, startPayDocNo).ToString();
			startPayDocNo += obj.Count();

			FileReadWriter.WriteAllTextANSI(fileName, res);

			documentsModel.LastDocumentNo = startNo;
			documentsModel.LastPayDocNo = startPayDocNo;
			documentsModel.SaveDocuments(obj);
			view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
		}

		private void View_BtnCreateWork(WorkDocument wd)
		{
			if (wd == null) return;
			if (!CanEditDocument(view.CurrentWorkDocument)) return;

			// change to that like as View_BtnCreateDocument (view.ChooseEmployees(documentsModel.GetEmployees());)
			// I mean that the view must contain different IView and give a method
			// А можно и передавать при создании пачку IView в параметрах конструктора
			IWorkForm workForm = new WorkForm();
			workForm.BtnStartChooseWorkPosition = () => {
				// Вариант спрятать IWorkForm в IMainView. 
				MonthTaskBankPresenter taskBankPresenter = new MonthTaskBankPresenter();
				taskBankPresenter.Go();
			};

			Work w = new Work();

			workForm.SetWork(w);
			var res = workForm.GetWork();

			if (res != null)
			{
				documentsModel.AddWork(wd, w);
				view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
			}
		}
		private void View_BtnEditWork(Work obj)
		{
			if (obj == null) return;
			if (!CanEditDocument(view.CurrentWorkDocument)) return;

			IWorkForm workForm = new WorkForm();

			workForm.SetWork(obj.Clone());
			var res = workForm.GetWork();

			if (res != null)
			{
				obj.Accept(res);
				documentsModel.SaveWork(obj);
				view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
			}
		}
		private void View_BtnDeleteWork(Work obj)
		{
			if (obj == null) return;
			if (!CanEditDocument(view.CurrentWorkDocument)) return;
			if (!view.UserAnswerYes($"Работа {obj.Name} будет удалена. Подтвердите")) return;

			documentsModel.DeleteWork(obj);

			view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
		}

		bool CanEditDocument(WorkDocument doc)
		{
			if (doc.PayDocMaked)
			{
				view.ShowMsg($"Документ {view.CurrentWorkDocument.Title} закрыт. Изменения невозможны");
				return false;
			}
			return true;
		}
		private void View_BtnCreateDocument()
		{
			var empl = view.ChooseEmployees(documentsModel.GetEmployees());
			if (empl == null) return;

			var docs = empl.Select(x => documentsModel.CreateDocument(view.Date, x));// move into the model
			documentsModel.SaveDocuments(docs);// move into the model

			view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
		}

		private void View_BtnDeleteDocument(WorkDocument obj)
		{
			if (obj == null) return;

			if (!view.UserAnswerYes($"Документ {obj.Title} будет удален. Подтвердите")) return;

			documentsModel.DeleteDocument(obj);
			view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
		}
		private void View_DateChanged()
		{
			view.SetDocuments(documentsModel.GetDocuments(view.Date.Year, view.Date.Month));
		}
	}
}
