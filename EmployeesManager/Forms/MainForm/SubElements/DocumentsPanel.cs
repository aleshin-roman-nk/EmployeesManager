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

namespace EmployeesManager.Forms.MainForm.SubElements
{
	public partial class DocumentsPanel : UserControl, IViewPanel
	{
		public DocumentsPanel()
		{
			InitializeComponent();
		}

		void IViewPanel.Enter()
		{
			throw new NotImplementedException();
		}

		void IViewPanel.Leave()
		{
			throw new NotImplementedException();
		}
	}
}
