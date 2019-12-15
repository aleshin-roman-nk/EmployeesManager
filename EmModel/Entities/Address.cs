using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class Address
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string Postcode { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string Building { get; set; }
		public string Apartment { get; set; }
	}
}
