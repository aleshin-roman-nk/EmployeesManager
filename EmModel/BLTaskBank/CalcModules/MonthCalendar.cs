using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.BLTaskBank.CalcModules
{
	public class MonthCalendar
	{
		List<DateTime> dates;
		public string MonthName { get; set; }
		public MonthCalendar(int year, int month)
		{
			dates = GetDates(year, month);
			MonthName = new DateTime(year, month, 1).ToString("MMMM");
		}
		private List<DateTime> GetDates(int year, int month)
		{
			return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
							 .Select(day => new DateTime(year, month, day))
							 .ToList();
		}
		public int GetDayAmount(int dayOfWeek)
		{
			if (dayOfWeek == 7) dayOfWeek = 0;
			return dates.Where(x => int.Parse(x.DayOfWeek.ToString("d")) == (int)dayOfWeek).Count();
		}
		public int GetDayAmountOfRange(int[] dayOfWeek)
		{
			var days = dayOfWeek.Select(x => x == 7 ? 0 : x).ToArray();

			return dates.Where(x =>
			days.Contains(int.Parse(x.DayOfWeek.ToString("d")))).Count();
		}
	}
}
