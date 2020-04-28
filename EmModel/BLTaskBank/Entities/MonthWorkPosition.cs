using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.BLTaskBank.Entities
{
	public class MonthWorkPosition
	{
		private Dictionary<int, bool> whatDays = new Dictionary<int, bool>();

		public int Id { get; set; }
		public string Name { get; set; }
		public string DaysOfWeek 
		{
			get { return Newtonsoft.Json.JsonConvert.SerializeObject(whatDays); }
			set { whatDays = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, bool>>(value); } 
		}
		public decimal Budget { get; set; }
		public int ShiftAmout { get; set; }

		public IEnumerable<int> Days
		{
			get
			{
				return whatDays.Where(x => x.Value).Select(x => x.Key).ToList();
			}
		}

		public decimal ShiftPrice
		{
			get
			{
				decimal price = Budget / ShiftAmout;

				var d = 2;
				price /= d;
				price = price - Math.Truncate(price) == 0 ? price * d : (Math.Truncate(++price) * d);

				return price;
			}
		}
	}
}
