using EmModel.DbAccess;
using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class ConfigsModel
	{
		public ProjectConfig Variables { get; } = new ProjectConfig();
		public void Load()
		{
			using (DbAppData db = new DbAppData())
			{
				Type confType = Variables.GetType();

				foreach (var prp in confType.GetProperties())
				{
					var val = db.Variables.FirstOrDefault(x=>x.Name.Equals(prp.Name));

					// if doesn't exist
					if(val == null)
					{
						val = new Variable { Name = prp.Name, Value = "" };
						db.Entry(val).State = System.Data.Entity.EntityState.Added;
						db.SaveChanges();
					}
					else// if exists
					{
						prp.SetValue(Variables, val.Value);
					}
				}
			}
		}
		public void Save()
		{
			using (DbAppData db = new DbAppData())
			{
				Type confType = Variables.GetType();

				foreach (var prp in confType.GetProperties())
				{
					var val = db.Variables.FirstOrDefault(x => x.Name.Equals(prp.Name));

					// if doesn't exist
					if (val == null)
					{
						val = new Variable { Name = prp.Name, Value = "" };
						db.Entry(val).State = System.Data.Entity.EntityState.Added;
						db.SaveChanges();
					}
					else// if exists
					{
						val.Value = prp.GetValue(Variables) as string;
						db.SaveChanges();
					}
				}
			}
		}
	}
}
