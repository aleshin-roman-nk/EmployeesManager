using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesManager.Forms.MainForm.InternalUILogic;
using EmModel.Entities;

/*
 * Все интерфейсние метода для презентера в MainView
 * Интерфейсное взаимодействие Presenter - View
 * 
 * 
 * От виев поступает запрос дать коллекцию
 *	- тип, параметры
 *	
 *	
 * Разработать программку финансовой картины.
 *		Работа с месяцем. Ввод наличного положения. Отдельным блоком действующие долги (не привязанны к месяцу).
 *		В течение месяца вносить поступления и расходы.
 * 
 * Разрабатывая, чтобы не блуждать, необходимо привести весь список требований и используемых данных.
 * 
 */

namespace EmployeesManager.Forms.MainForm.SubElements
{
	public interface IYearsPanel
	{
		DataGridView DataGrid { get; set; }
		void SetData(IEnumerable<Year> list);
	}

	public partial class YearsPanel : UserControl, IViewPanel, IYearsPanel
	{
		int currentYear { get; set; }

		public YearsPanel()
		{
			InitializeComponent();
		}

		public DataGridView DataGrid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		void IViewPanel.Enter()
		{
			DataGrid.Columns.Clear();

			// 1. Запрос данных
			//LevelChanged?.Invoke(Level.Years);

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

			DataGrid.Columns.Add(col1);
			//DataGrid.DataSource = bsMainGridYears;

			// Заменить на логику смены показа IView, вложенные view
			// Не забывать про возможность делать элементы через UserControls
		}

		void IViewPanel.Leave()
		{
			throw new NotImplementedException();
		}

		public void SetData(IEnumerable<Year> list)
		{
			throw new NotImplementedException();
		}
	}
}
