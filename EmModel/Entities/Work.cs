using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class Work
	{
		public int Id { get; set; }
		public int WorkDocumentId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal Sum { get => Price * Count; }
	}
}
