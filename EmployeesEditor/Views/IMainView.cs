using EmModel.Entities;
using EmModel.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesEditor.Views
{
	public interface IMainView
	{
		event Action CreateEmployee;
		event Action<UIEmployee> RemoveEmployee;
		event Action<UIEmployee> StoreEmployee;
		void Msg(string str);
		bool UserAnswerYes(string msg, string warning);
		void SetEmployees(IEnumerable<UIEmployee> empls);
		event Action<IEnumerable<UIEmployee>> GenerateContracts;
	}
}
