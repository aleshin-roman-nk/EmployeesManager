using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthTasksBank
{
	public class MonthTaskBankPresenter
	{
		public void Go()
		{
			MonthTaskBankForm form = new MonthTaskBankForm();

			form.ShowDialog();
		}
	}
}
