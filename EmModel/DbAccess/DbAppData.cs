using EmModel.BLTaskBank.Entities;
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
		public DbAppData(string cn = @"Data Source = ..\..\..\db\data.db") : base(cn)
		//public DbAppData(string cn = @"Data Source = data.db") : base(cn)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<BankAcc> BankAccs { get; set; }
		public DbSet<Passport> Passports { get; set; }
		public DbSet<Business> Businesses { get; set; }
		public DbSet<WorkDocument> WorkDocuments { get; set; }
		public DbSet<Work> Works { get; set; }
		public DbSet<Variable> Variables { get; set; }
		public DbSet<MonthWorkPosition> MonthWorkPositions { get; set; }
	}
}
