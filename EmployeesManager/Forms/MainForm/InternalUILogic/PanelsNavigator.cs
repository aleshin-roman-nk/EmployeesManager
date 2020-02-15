using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Вообще здесь должен быть какой то роутинг.
 * Презентер общается с IMainView
 *	Презентер подписан на события IMainView
 *	Презентер передает в IMainView запрошенные данные.
 *	
 * 
 * 
 */

namespace EmployeesManager.Forms.MainForm.InternalUILogic
{
	public interface IEntity
	{
		int Id { get; set; }
	}

	// В целом панель работает с одним типом сущности.
	public class PanelItem//: IViewPanel
	{
		public Control Panel { get; set; }
		public Action<PanelItem> Enter { get; set; }
		public int CurrentId { get; set; }
		public BindingSource Data { get; set; }

		//public void Enter()
		//{
			
		//}

		public void Leave()
		{
			//CurrentId = 
		}
	}

	public class PanelsNavigator
	{
		List<PanelItem> panels = new List<PanelItem>();
		int pos = 0;

		public void Add(Control panel, Action<PanelItem> init)
		{
			panels.Add(new PanelItem { Panel = panel, Enter = init });
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

		private void EnterCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Enter(panels[pos]);
			Show(panels[pos].Panel);
		}

		private void LeaveCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Leave();
		}

		public void TurnNext()
		{
			LeaveCurrent();
			Next();
			EnterCurrent();
		}

		public void TurnBack()
		{
			Prev();
			EnterCurrent();
		}

		public void TurnFirst()
		{
			pos = 0;
			EnterCurrent();
		}
	}
}
