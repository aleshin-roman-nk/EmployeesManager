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
		public WorkDocument Create()
		{
			return new WorkDocument
			{

			};
		}
		public WorkDocument CurrentDocument { get; set; }
		public void Save(WorkDocument doc)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(doc).State = doc.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		public IEnumerable<WorkDocument> GetDocuments(Month m)
		{
			using (DbAppData db = new DbAppData())
			{
				return db.WorkDocuments.Where(x => x.MonthId == m.Id).ToList();
			}
		}
	}
}
