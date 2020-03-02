using EmModel.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public interface IPanel
	{
		IEnumerable<GridPanelColumn> Columns { get; }
		BindingSource BS { get; }
	}
}
