using EmModel.Entities;
using EmModel.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class EmployeesModel
	{
		public void AddEmployee(Employee empl)
		{

		}

		public IEnumerable<UIEmployee> GetUIEmployees()
		{
			return new UIEmployee[]
			{
				new UIEmployee{ Address = new Address{Postcode = "654044", Apartment = "39", Building = "78", City = "Новокузнецк", Street = "Косыгина"},
								Employee = new Employee{ Name = "Роман", Surname = "Алешин", Patronymic = "Владимирович"} },

				new UIEmployee{ Address = new Address{Postcode = "654066", Apartment = "67", Building = "90", City = "Новокузнецк", Street = "Авиаторов"},
								Employee = new Employee{Name = "Наталья", Surname = "Алешина", Patronymic = "Николаевна"} },

				new UIEmployee{ Address = new Address{Postcode = "654065", Apartment = "100", Building = "120", City = "Новокузнецк", Street = "Авиаторов 2"},
								Employee = new Employee{Name = "Виталий", Surname = "Алешин", Patronymic = "Романович"} }
			};
		}
	}
}
