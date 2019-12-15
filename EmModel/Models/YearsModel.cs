using EmModel.DbAccess;
using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class YearsModel
	{
		public YearsModel()
		{
			CurrentYear = Years.First();
		}

		public Year CurrentYear { get; set; }
		public IEnumerable<Year> Years
		{
			get
			{
				using (DbAppData db = new DbAppData())
				{
					return db.Years.Include("Months").ToList();
				}
			}
		}

		public Year CreateYear(string y)
		{
			Year year = new Year { Name = y };

			// Кажется эти using и доступ к данным нужно перенести в слой доступа к данным.
			// Не следует напрямую обращаться к механизму бд из модели
			// Доступ к дб должен располагаться в папке DbAccess
			// Однако здесь можем создавать, настраивать, строить сущности.
			//		но чтение, запись должно быть перенесенно в слой DbAccess
			using (DbAppData db = new DbAppData())
			{
				var y_ = db.Years.FirstOrDefault(x => x.Name.Equals(y));
				if (y_ != null) throw new ArgumentException($"{y} уже существует в системе");

				year = createMonths(year);

				db.Entry(year).State = EntityState.Added;

				foreach (var item in year.Months)
				{
					db.Entry(item).State = EntityState.Added;
				}

				db.SaveChanges();
			}

			return year;
		}

		Year createMonths(Year year)
		{
			var m = getMonthsCollection();

			foreach (var item in m)
			{
				Month month = new Month
				{
					Name = item.Value,
					YearId = year.Id
				};
				year.Months.Add(month);
			}

			return year;
		}

		Dictionary<int, string> getMonthsCollection()
		{
			var res = new Dictionary<int, string>();

			res[1] = "Январь";
			res[2] = "Февраль";
			res[3] = "Март";
			res[4] = "Апрель";
			res[5] = "Май";
			res[6] = "Июнь";
			res[7] = "Июль";
			res[8] = "Август";
			res[9] = "Сентябрь";
			res[10] = "Октябрь";
			res[11] = "Ноябрь";
			res[12] = "Декабрь";

			return res;
		}
	}
}
