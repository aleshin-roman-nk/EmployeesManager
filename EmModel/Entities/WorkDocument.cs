using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class WorkDocument
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public int MonthId { get; set; }
		public List<Work> Works { get; set; } = new List<Work>();
	}
}
