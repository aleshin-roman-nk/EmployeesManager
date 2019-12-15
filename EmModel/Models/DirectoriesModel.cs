using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class DirectoriesModel
	{
		List<Year> Data;

		public IEnumerable<Year> GetYears()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Month> GetMonths(Year year)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<WorkDocument> GetWorkDocuments(Month month)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Work> GetWorks(WorkDocument document)
		{
			throw new NotImplementedException();
		}
	}
}
