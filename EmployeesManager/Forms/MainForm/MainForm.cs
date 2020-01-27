﻿using EmModel.Entities;
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
 * >>>
 * 18-12-2019
 * Менять всю картину а не поотдельности. Т.е. менять вид комплексно.
 * 
 * root (Years)
 * |->Months
 *		|->WorkDocuments
 *			|->Works
 * 
 * При нажатии "вход в объект" запросить этот объект, со всем содержимым объекта, но только без под уровней
 * 
 * Находимся на уровне Years
 *	Нажатие войти в Year
 *	0. Сохранить какой текущий год
 *	1. Запрос получить месяцы года
 *	2. Биндинг коллекции месяцев
 *	3. Включить панель месяца
 * 
 * 
 * >>>
 * 26-12-2019
 * После входа в объект мы должны знать его как текущий, например для того, чтобы отображать, в каком объекте находимся. А еще лучше "Хлебную крошку текущих объектов". Т.е. весь связанный список текущих
 *	объектов.
 *	Поэтому все же нужно иметь объект информации о текущем объекте (Система пути.)
 *	
 *	>>>
 *	27-12-2019
 *	Нужно переразработать что то более серьезное чем отдельные акшион навигатор
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
		ShowPanelsManager showPanelsManager = new ShowPanelsManager();
		CurrentObjects currentObjects = new CurrentObjects();

		public event Action UserCreatesYear;
		public event Action<Year> YearSelected;
		public event Action<Month> MonthSelected;
		public event Action<Level> LevelChanged;

		public MainForm()
		{
			InitializeComponent();

			gridMain.AutoGenerateColumns = false;
			gridMain.DataSource = bsMainGrid;

			// лучше принимать не просто Control а интерфейс, который имеет контракт требований и описание что это
			// можно как компонент, которому отдаем ссылку на grid control, он уж сам привязывается к событиям ентера
			//	м backspace
			showPanelsManager.AddPanel(yearsPanel);
			showPanelsManager.AddPanel(monthsPanel);
			showPanelsManager.AddPanel(workDokumentsPanel);
			showPanelsManager.AddPanel(employeeControl1);

			navigator.Add(activatePanelYears);
			navigator.Add(activatePanelMonths);
			navigator.Add(activatePanelWorkDocuments);
			navigator.Add(activatePanelWorks);
			navigator.TurnFirst();

			bsMainGridYears.CurrentItemChanged += BsMainGridYears_CurrentItemChanged;
			bsMainGridMonths.CurrentItemChanged += BsMainGridMonths_CurrentItemChanged;
		}

		public void SetEmployees(IEnumerable<UIEmployee> list)
		{
			bsMainGrid.DataSource = list;
			bsMainGrid.DataSource = typeof(UIEmployee);
			gridMain.DataSource = bsMainGrid;
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
		 *	
		 *	>>>
		 *	14-01-2020 1-40
		 *	Надо скомпоновать в одну сущность (*1):
		 *		Настройка вида
		 *		Запрос данных контроллеру (презентеру)
		 *		Настройка привязок.
		 *	Состояние текущих объектов (структура year.month.doc.work) хранится в этом же классе
		 *		что и контроллирует коллекцию сущностей (*1)
		 *	
		 */


		 /*
		  * 
		  * >>> 19-01-2020 2-17
		  * Можно назвать activateViewYears
		  * Активируем view.
		  * 
		  * Выполняется код активации вида.
		  * 1. Запрос данных
		  * 2. Привязка данных
		  * 3. Отобразить панель
		  * 
		  * 
		  * 
		  */
		private void activatePanelYears()
		{
			gridMain.Columns.Clear();

			// 1. Запрос данных
			LevelChanged?.Invoke(Level.Years);

			// 2. Настройка вида
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

			// Показать панель тоже входит в настройку вида
			//	Настройка вида:
			//		- настройка сетки
			//		- показ панели
			showPanelsManager.Show(yearsPanel);
			// Заменить на логику смены показа IView, вложенные view
			// Не забывать про возможность делать элементы через UserControls
		}

		// Сценарий активации
		private void activatePanelMonths()
		{
			// просто оповещать что сменился текущий год, месяц и т.д.
			//	модель соответствеено меняет структуру текущих данных.
			//		при запросе данных, модель сама знает что отдать
			//		в случае веб реализации, структура текущих данных должна находиться во view
			//			либо можно создать класс данных, относящихся к ui и находиться будет в view как логика ui

			/*
			 * 22-12-2019 1-52
			 * Механизм связанной очереди, дерева. Указатель, ссылка на текущий объект, содержащий информацию, какой объект сейчас текущий.
			 *		дерево объектов не непосредственно объект модели, а объект класса ui, содержащий отмеченный объект модели
			 */

			// В принципе здесь только настройка сетки
			// view может быть как логически объединенная единица, имеющая механизмы UI и получающая ссылки на контролы
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

			showPanelsManager.Show(monthsPanel);
		}

		void activatePanelWorkDocuments()
		{
			gridMain.Columns.Clear();
			gridMain.DataSource = null;
			showPanelsManager.Show(workDokumentsPanel);
		}

		void activatePanelWorks()
		{
			gridMain.Columns.Clear();
			gridMain.DataSource = null;
			showPanelsManager.Show(employeeControl1); 
		}

		private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				navigator.TurnNext();
				//navigator.ExecCurrent();
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.Back)
			{
				navigator.TurnBack();
				//navigator.ExecCurrent();
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
