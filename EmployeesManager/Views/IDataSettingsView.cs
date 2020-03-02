using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Views
{
	public interface IDataSettingsView
	{
		void SetWorkTypes(IEnumerable<WorkType> wtlist);
		WorkType GetWorkType();
		event Action BtnCreateWorkType;
		event Action<WorkType> BtnDeleteWorkType;
	}
}