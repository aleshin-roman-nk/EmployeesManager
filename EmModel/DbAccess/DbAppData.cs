using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.DbAccess
{
	public class DbAppData : DbContext
	{
		public DbAppData(string cn = @"Data Source = ..\..\db\data.db") : base(cn)
		//public DbAppData(string cn = @"Data Source = data.db") : base(cn)
		{

		}

		public DbSet<Year> Years { get; set; }
		public DbSet<Month> Months { get; set; }
		public DbSet<WorkDocument> WorkDocuments { get; set; }
		public DbSet<Work> Works { get; set; }
	}
}
