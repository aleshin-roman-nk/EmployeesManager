using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class Month
	{
		public int Id { get; set; }
		public int YearId { get; set; }
		public string Name { get; set; }
		public List<WorkDocument> WorkDocuments { get; set; } = new List<WorkDocument>();
	}
}
