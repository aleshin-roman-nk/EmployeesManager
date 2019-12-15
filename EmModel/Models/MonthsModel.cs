using EmModel.DbAccess;
using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class MonthsModel
	{
		public Month CurrentMonth { get; set; }
		public IEnumerable<Month> GetMonths(Year year)
		{
			using (DbAppData db = new DbAppData())
			{
				return db.Months.Where(x => x.YearId == year.Id).ToList();
			}
		}
	}
}
