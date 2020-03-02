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
		public Address Clone()
		{
			return new Address
			{
				Postcode = Postcode,
				City = City,
				Street = Street,
				Building = Building,
				Apartment = Apartment
			};
		}
		public void Accept(Address src)
		{
			City = src.City;
			Postcode = src.Postcode;
			Street = src.Street;
			Building = src.Building;
			Apartment = src.Apartment;
		}
	}
}
