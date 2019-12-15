using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Forms.MainForm.InternalUILogic
{
	public enum EnterWay { Down, Up }

	public class ActionsNavigator
	{
		List<Action> actions = new List<Action>();
		int pos = 0;
		public void Add(Action a)
		{
			actions.Add(a);
		}

		public void Next()
		{
			if (pos == actions.Count - 1) return;
			pos++;
		}

		public void Prev()
		{
			if (pos == 0) return;
			pos--;
		}

		public void ExecCurrent()
		{
			if (actions.Count == 0) return;
			actions[pos]();
		}
	}
}
