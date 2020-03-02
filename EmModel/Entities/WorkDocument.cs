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
		public int No { get; set; }
		public int? EmployeeId { get; set; }
		public Employee Employee { get; set; }
		public DateTime Date { get; set; }
		public string Title { get { return $"N{No} / {Date.ToString("yyyy.MM.dd")}  / {Employee.ShortName}"; } }
		public List<Work> Works { get; set; } = new List<Work>();
		public decimal TotalSum
		{
			get
			{
				return Works.Sum(x => x.Sum);
			}
		}
		public bool PayDocMaked { get; set; }
	}
}
