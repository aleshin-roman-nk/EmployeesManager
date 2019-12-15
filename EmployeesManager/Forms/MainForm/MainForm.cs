using EmModel.Entities;
using EmModel.Entities.UI;
using EmployeesManager.Forms.Dialogs;
using EmployeesManager.Forms.MainForm.InternalUILogic;
using EmployeesManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Пользоваться моками-слоями данных. Т.е. интерфейсный слой методов. Генерация данных.
 *		Просто продуманный интерфейс методов.
 *		Генератор тестовых данных. Без необходимости строить бд с самого начала
 *		Хотя можно создать вспомогательную утилиту, создание sql запроса таблицы и генерация класса по сущности.
 * 
 * 
 * 
 * >>>
 * Для программы расчета доходов и долгов. Строить объект периода.
 *	Т.е. запрос объекта с параметром периода. Модель возвращает содзанный объект с рассчитанными данными.
 *			При этом налоги выбираются с начала года.
 * Для запроса объекта, можно задавать в параметре строку вида "2019.Q2" или "2018.M10"
 *		Или как нибудь типа Period.Get(2019).Q1... Не очень удобно... Можно так лучше
 *				Period.Get(2019, PeriodItem.Q1);
 *				 Нет, удобнее сформировать и распарсить строку "2019.Q2"
 *					Или вообще через объект-параметр: Period.Get( new PeriodParams(2019, "Q1") );
 *						Или совсем вообще Period.Get(2019, "Q3", sinceFirstJan = true/false);
 *				 
 *	Идея приема UI логики - буффер отображаемых контролов, которые можно одним разом закрыть.
 *			Т.е. показывается всплывающий контрол, помещается в буффер. В нужный момент дать команду выключить
 *				все, что находится в буффере.
 *				
 *	Разобраться, как устроены миграции.
 * 
 * >>>
 * 25-11-2019
 *	Объединить сетку и коллекция панелей в один логический класс
 *	Переработать поновой общую схему алгоритма работы механизма вхождения - запроса, локализовать ответственнойсти модулей
 *	1. Исходное состояние. 
 * 
 * 
 */

namespace EmployeesManager
{
	public partial class MainForm : Form, IMainView
	{
		BindingSource bsMainGrid = new BindingSource();
		BindingSource bsMainGridYears = new BindingSource();
		BindingSource bsMainGridMonths = new BindingSource();
		BindingSource bsAddress = new BindingSource();

		ActionsNavigator navigator = new ActionsNavigator();
		ShowControlsManager showControlsManager = new ShowControlsManager();

		public event Action UserCreatesYear;
		public event Action<Year> YearSelected;
		public event Action<Month> MonthSelected;
		public event Action<Level> LevelChanged;

		public MainForm()
		{
			InitializeComponent();

			showControlsManager.AddControlPanel(yearsPanel);
			showControlsManager.AddControlPanel(monthsPanel);
			showControlsManager.AddControlPanel(workDokumentsPanel);
			showControlsManager.AddControlPanel(employeeControl1);

			gridMain.AutoGenerateColumns = false;
			gridMain.DataSource = bsMainGrid;

			navigator.Add(navYears);
			navigator.Add(navMonths);
			navigator.Add(navWorkDocuments);
			navigator.Add(navWorks);
			navigator.ExecCurrent();

			bsMainGridYears.CurrentItemChanged += BsMainGridYears_CurrentItemChanged;
			bsMainGridMonths.CurrentItemChanged += BsMainGridMonths_CurrentItemChanged;
		}

		public void SetEmployees(IEnumerable<UIEmployee> list)
		{
			bsMainGrid.DataSource = typeof(UIEmployee);
			gridMain.AutoGenerateColumns = false;
			gridMain.DataSource = bsMainGrid;

			bsMainGrid.DataSource = list;
			bsMainGrid.ResetBindings(false);

			bsAddress.DataSource = bsMainGrid;
			bsAddress.DataMember = "Address";

			txtBuilding.DataBindings.Clear();
			txtStreet.DataBindings.Clear();
			txtFIO.DataBindings.Clear();

			txtBuilding.DataBindings.Add("Text", bsAddress, "Building");
			txtStreet.DataBindings.Add("Text", bsAddress, "Street");
			txtFIO.DataBindings.Add("Text", bsMainGrid, "ShortName");
		}
		private void BsMainGridYears_CurrentItemChanged(object sender, EventArgs e)
		{
			YearSelected?.Invoke(bsMainGridYears.Current as Year);
		}
		private void BsMainGridMonths_CurrentItemChanged(object sender, EventArgs e)
		{
			MonthSelected?.Invoke(bsMainGridMonths.Current as Month);
		}
		public void SetYears(IEnumerable<Year> years, Year cur)
		{
			bsMainGridYears.DataSource = years;
			
			var c = years.FirstOrDefault(x => x.Id == cur.Id);
			bsMainGridYears.Position = bsMainGridYears.IndexOf(c);
		}
		public void SetCurrentTitle(string cur)
		{
			Text = cur;
		}
		public void SetMonths(IEnumerable<Month> months, Month cur)
		{
			lblCurrentMonth.DataBindings.Clear();
			bsMainGridMonths.DataSource = months;
			
			if (cur != null)
			{
				var c = months.FirstOrDefault(x => x.Id == cur.Id);
				bsMainGridMonths.Position = bsMainGridMonths.IndexOf(c);
			}

			lblCurrentMonth.DataBindings.Add("Text", bsMainGridMonths, "Name");
		}

		/*
		 * Код выполняется, когда происходит вход в режим просмотра годов.
		 *	Сетка конфигурирется для показа годов
		 */
		private void navYears()
		{
			gridMain.Columns.Clear();
			// запрос данных
			// после выполнения этой строчки presenter уже выдал необходимые данные
			LevelChanged?.Invoke(Level.Years);

			// 29-11-2019 >>>
			// код настройки вида перенести в композитный класс, который настраивает контролы и показывает нужную панель
			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Name",
				HeaderText = "Год",
				Name = "col1",
				ReadOnly = true,
				Width = 300
			};

			gridMain.Columns.Add(col1);
			gridMain.DataSource = bsMainGridYears;

			showControlsManager.Show(yearsPanel);
			// Заменить на логику смены показа IView, вложенные view
			// Не забывать про возможность делать элементы через UserControls
		}
		private void navMonths()
		{
			// просто оповещать что сменился текущий год, месяц и т.д.
			//	модель соответствеено меняет структуру текущих данных.
			//		при запросе данных, модель сама знает что отдать
			//		в случае веб реализации, структура текущих данных должна находиться во view
			//			либо можно создать класс данных, относящихся к ui и находиться будет в view как логика ui

			gridMain.Columns.Clear();
			LevelChanged?.Invoke(Level.Months);
			
			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Name",
				HeaderText = "Месяцы",
				Name = "col1",
				ReadOnly = true,
				Width = 300
			};

			gridMain.Columns.Add(col1);

			gridMain.DataSource = bsMainGridMonths;

			showControlsManager.Show(monthsPanel);
		}

		void navWorkDocuments()
		{
			gridMain.Columns.Clear();
			gridMain.DataSource = null;
			showControlsManager.Show(workDokumentsPanel);
		}

		void navWorks()
		{
			gridMain.Columns.Clear();
			gridMain.DataSource = null;
			showControlsManager.Show(employeeControl1); 
		}

		private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				navigator.Next();
				navigator.ExecCurrent();
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.Back)
			{
				navigator.Prev();
				navigator.ExecCurrent();
				e.Handled = true;
			}
		}

		public void InitEvents()
		{

		}

		private void BtnCreateYear_Click(object sender, EventArgs e)
		{
			UserCreatesYear?.Invoke();
		}

		public void ShowMsg(string msg)
		{
			MessageBox.Show(msg);
		}

		public string DlgInputString
		{
			get
			{
				IInputStringDlg dlg = new InputStringDlg();
				var r = dlg.ShowDlg();
				return r == DialogResult.OK ? dlg.InputString : null;
			}
		}
	}

	// Либо дополнительное событие смена уровня

	//Лучше запросы сохранения-чтения текущего элемента
	//class CurrentStateManager
	//{
	//	public Year CurrentYear { get; set; }
	//	public Month CurrentMonth { get; set; }
	//}
}
