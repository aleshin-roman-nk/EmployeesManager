using EmModel;
using EmployeesManager.Presenters;
using EmployeesManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm v = new MainForm();

			MainPresenter presenter = new MainPresenter(v);
			
			Application.Run(v);			
		}
	}
}
