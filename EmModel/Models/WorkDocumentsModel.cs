using EmModel.DbAccess;
using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class WorkDocumentsModel
	{
		public void AddWork(WorkDocument doc, Work w)
		{
			w.WorkDocumentId = doc.Id;

			using (DbAppData db = new DbAppData())
			{
				db.Entry(w).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
			}
		}
		public WorkDocument CreateDocument(DateTime dt, Employee empl)
		{
			var date = new DateTime(dt.Year, dt.Month, dt.Day);

			return new WorkDocument { Date = date, EmployeeId = empl.Id, PayDocMaked = false };
		}
		public IEnumerable<Employee> GetEmployees()
		{
			using (DbAppData db = new DbAppData())
			{
				return db.Employees.ToList();
			}
		}
		public IEnumerable<WorkDocument> GetDocuments(int year, int month)
		{
			using (DbAppData db = new DbAppData())
			{
				int days = DateTime.DaysInMonth(year, month);
				var dt0 = new DateTime(year, month, 1);
				var dt1 = new DateTime(year, month, days);

				//return db.WorkDocuments.Include("Employee").Where(x=> x.Date.Year == year && x.Date.Month == month).ToList();
				return db.WorkDocuments.Include("Employee").Include("Works").Where(x=> x.Date >= dt0 && x.Date <= dt1).ToList();
			}
		}
		public void SaveDocument(WorkDocument doc)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(doc).State = doc.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				foreach (var w in doc.Works)
					db.Entry(w).State = w.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

				db.SaveChanges();
			}
		}
		public void SaveDocuments(IEnumerable<WorkDocument> docs)
		{
			using (DbAppData db = new DbAppData())
			{
				foreach (var doc in docs)
				{
					db.Entry(doc).State = doc.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
					foreach (var w in doc.Works)
						db.Entry(w).State = w.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				}

				db.SaveChanges();
			}
		}
		public void SaveWork(Work w)
		{
			using(DbAppData db = new DbAppData())
			{
				db.Entry(w).State = w.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public void DeleteWork(Work w)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(w).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public void DeleteDocument(WorkDocument wd)
		{
			using (DbAppData db = new DbAppData())
			{
				var workDoc = db.WorkDocuments.Include("Works").FirstOrDefault(x => x.Id == wd.Id);
				if (workDoc != null) db.WorkDocuments.Remove(workDoc);
				db.SaveChanges();
			}
		}
		public IEnumerable<WorkDocumentEx> GetWorkDocumentsEx(IEnumerable<WorkDocument> docs)
		{
			using (DbAppData db = new DbAppData())
			{
				foreach (var doc in docs)
				{
					if (doc.PayDocMaked) continue;

					var busn = db.Businesses.First(x => x.EmployeeId == doc.EmployeeId);
					var bancacc = db.BankAccs.First(x => x.EmployeeId == doc.EmployeeId);

					yield return new WorkDocumentEx
					{
						BankAcc = bancacc,
						Business = busn,
						WorkDocument = doc
					};
				}
			}
		}
		public WorkDocumentEx GetWorkDocumentExByFIO(string fio)
		{
			using (DbAppData db = new DbAppData())
			{
				var empl = db.Employees.ToList().FirstOrDefault(x => x.FullName.ToUpper().Equals(fio.ToUpper()));
				if (empl == null) return null;
				var busn = db.Businesses.First(x => x.EmployeeId == empl.Id);
				var bancacc = db.BankAccs.First(x => x.EmployeeId == empl.Id);

				return new WorkDocumentEx
				{
					Employee = empl,
					Business = busn,
					BankAcc = bancacc
				};
			}
		}
		public int LastDocumentNo
		{
			get
			{
				ConfigsModel configs = new ConfigsModel();
				configs.Load();
				var prop = configs.Variables.LastWorkDocument;
				return string.IsNullOrEmpty(prop) ? 0 : int.Parse(prop);
			}
			set
			{
				ConfigsModel configs = new ConfigsModel();
				configs.Load();
				configs.Variables.LastWorkDocument = value.ToString();
				configs.Save();
			}
		}
		public int LastPayDocNo
		{
			get
			{
				ConfigsModel configs = new ConfigsModel();
				configs.Load();
				var prop = configs.Variables.LastPayDocNo;
				return string.IsNullOrEmpty(prop) ? 0 : int.Parse(prop);
			}
			set
			{
				ConfigsModel configs = new ConfigsModel();
				configs.Load();
				configs.Variables.LastPayDocNo = value.ToString();
				configs.Save();
			}
		}
	}
}
