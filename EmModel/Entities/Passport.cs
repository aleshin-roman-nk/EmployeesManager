using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class Passport
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string SerialNumber { get; set; }
		public string IssuedBy { get; set; }
		public DateTime BornDay { get; set; }
		public DateTime PassportDate { get; set; }
		public Passport Clone()
		{
			return new Passport
			{
				SerialNumber = SerialNumber,
				BornDay = BornDay,
				IssuedBy = IssuedBy,
				PassportDate = PassportDate
			};
		}
		public void Accept(Passport src)
		{
			SerialNumber = src.SerialNumber;
			IssuedBy = src.IssuedBy;
			BornDay = src.BornDay;
			PassportDate = src.PassportDate;
		}
	}
}
