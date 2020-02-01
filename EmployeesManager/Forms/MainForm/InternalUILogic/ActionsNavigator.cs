using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager.Forms.MainForm.InternalUILogic
{
	public class PanelItem
	{
		public Control Panel { get; set; }
		public Action<PanelItem> Activate { get; set; }
		public int CurrentId { get; set; }
		public BindingSource Data { get; set; }
	}

	public class ActionsNavigator
	{
		List<PanelItem> panels = new List<PanelItem>();
		int pos = 0;

		public void Add(Control panel, Action<PanelItem> init)
		{
			panels.Add(new PanelItem { Panel = panel, Activate = init });
		}

		private void Next()
		{
			if (pos == panels.Count - 1) return;
			pos++;
		}

		private void Prev()
		{
			if (pos == 0) return;
			pos--;
		}

		void Show(Control panel)
		{
			var item = panels.FirstOrDefault(x => x.Panel.Name.Equals(panel.Name));
			if (item != null)
			{
				foreach (var ctrl in panels)
				{
					ctrl.Panel.Visible = false;
				}

				item.Panel.Visible = true;
				item.Panel.Dock = DockStyle.Fill;
			}
		}

		private void ExecCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Activate(panels[pos]);
			Show(panels[pos].Panel);
		}

		public void TurnNext()
		{
			Next();
			ExecCurrent();
		}

		public void TurnBack()
		{
			Prev();
			ExecCurrent();
		}

		public void TurnFirst()
		{
			pos = 0;
			ExecCurrent();
		}
	}
}
