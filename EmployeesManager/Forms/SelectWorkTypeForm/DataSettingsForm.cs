using EmModel.Entities;
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
 * Все настроечки сделать в одном окошке - компоненте.
 * Добавить - удалить - редактировать.
 * Окошечки выбора - добавления можно в типовом окне SelectObjectForm<IObj>
 *	где IObj имеет свойство Title
 * 
 * 
 * Использовать таблицу - объект переменных месяца.
 * 
 * 
 */

namespace EmployeesManager.Forms.DataSettingsForm
{
	public partial class DataSettingsForm : Form
	{
		public DataSettingsForm()
		{
			InitializeComponent();
		}
	}
}
