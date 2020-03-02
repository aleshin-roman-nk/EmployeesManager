using EmployeesEditor.Presenters;
using EmployeesEditor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEditor
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mainView = new MainForm();

			MainPresenter mainPresenter = new MainPresenter(mainView);

			Application.Run(mainView);
		}
	}
}
