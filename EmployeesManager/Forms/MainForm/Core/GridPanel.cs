using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public class GridPanel
	{
		public event Action Next;
		public event Action Back;
		private DataGridView Grid { get; set; }

		public GridPanel(DataGridView g)
		{
			Grid = g;
			Grid.AutoGenerateColumns = false;
		}

		public void Attach(BindingSource bs, IEnumerable<GridPanelColumn> colmns)
		{
			Grid.DataSource = bs;
			setColumns(colmns);
		}

		public void DetachAll()
		{
			Grid.DataSource = null;
			Grid.Columns.Clear();
		}

		private void setColumns(IEnumerable<GridPanelColumn> columns)
		{
			foreach (var item in columns)
				addColumn(item);
		}
		private void addColumn(GridPanelColumn col)
		{
			DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn
			{
				DataPropertyName = col.EntityPropertyName,
				HeaderText = col.Header,
				Name = col.Name,
				ReadOnly = true,
				Width = col.Width
			};

			Grid.Columns.Add(c);
		}
	}
}
