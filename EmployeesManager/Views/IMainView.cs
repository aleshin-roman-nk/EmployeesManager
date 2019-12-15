using EmModel.Entities;
using EmModel.Entities.UI;
using EmployeesManager.Forms.Dialogs;
using EmployeesManager.Forms.MainForm.InternalUILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Старт: Список годов показан
 * 
 * 1. Год выбран 
 * -> Месяцы года показаны
 * 
 * 2. Месяц выбран
 * -> Документы месяца показаны
 * 
 * 3. Документ выбран
 * -> работы документа показаны
 * 
 * 
 * модель такая: view запрашивает данные, модель готовит и отдает данные. презентер - склейка
 * 
 * Четко описать вид задачи, что я хочу, и разрабатывать это.
 * 
 * Year.Month.WorkDocument.Work
 * 2019.09.id439.id943
 * 
 * 
 */

namespace EmployeesManager.Views
{
	public interface IMainView
	{
		void SetEmployees(IEnumerable<UIEmployee> list);
		// - 1 или все же этот метод использовать для передачи в view всю структуру годов и месяцев. view имеет класс информации текущего выбора.
		// view будет запрашивать только документы и работы в документах. т.е. запрашивать содержание месяца
		//  при нажатии войти в объект происходит выполнение объекта установки вида, страницы
		void SetYears(IEnumerable<Year> years, Year current); 
		/*
		 * >>> 29-11-2019
		 * Отдавать комплекс данных согласно данному положению view
		 *	например, если view хочет войти в год, сохраняем текущий год (для адекватного возврата) (в view или в модели), отправляем запрос презентору (возбуждаем событие) с указанием необходимого года
		 *		презентер отдает коллекцию месяцев требуемого года, view переключает режим показа месяцев (настраивает сетку, подключает соответствующие источники данных, включает соответствующую панель информации)
		 *		
		 *	view запоминает текущий год. при возврате если такого года нет, выбираем первый
		 *	
		 *	нужен механизм, когда view запрашивает данные у модели (через презентер)
		 *		например так: Years
		 *	
		 * 
		 */
		void SetMonths(IEnumerable<Month> months, Month current);// убрать. уже отдали месяцы, передавая годы
		void SetCurrentTitle(string cur);

		event Action<Year> YearSelected;
		event Action<Month> MonthSelected;

		event Action<Level> LevelChanged;

		event Action UserCreatesYear;

		void InitEvents();

		string DlgInputString { get; }
		void ShowMsg(string msg);
	}

	public enum Level { Years, Months, WorkDocuments, Works}
	public class EventArgEnterLevel
	{
		public EventArgEnterLevel(Level l, object o)
		{
			Level = l;
			ObjParam = o;
		}
		public Level Level { get; set; }
		public object ObjParam { get; set; }
	}
}
