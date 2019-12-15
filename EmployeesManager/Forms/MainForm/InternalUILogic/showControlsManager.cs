using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager.Forms.MainForm.InternalUILogic
{
	class showControlsManager
	{
		List<Control> controls = new List<Control>();

		public void AddControlPanel(Control control)
		{
			controls.Add(control);
		}

		public void Show(Control control)
		{
			var item = controls.FirstOrDefault(x => x.Name.Equals(control.Name));
			if (item != null)
			{
				foreach (var ctrl in controls)
				{
					ctrl.Visible = false;
				}

				item.Visible = true;
				item.Dock = DockStyle.Fill;
			}
		}
	}
}
