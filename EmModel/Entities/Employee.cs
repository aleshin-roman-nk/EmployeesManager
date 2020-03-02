using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Не нужно брать коллекцию номеров актов из базы.
 *	Создав набор документв-актов, выдавать номера только при непосредственно отправке на оплату (экспорт в формат 1с)
 * 
 */

namespace EmModel.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }
		public string FullName { get { return $"{Surname} {Name} {Patronymic}"; } }
		public string ShortName {  get => $"{Surname} {Name[0]}. {Patronymic[0]}"; }

		public Employee Clone()
		{
			return new Employee
			{
				Id = this.Id,
				Name = this.Name,
				Surname = this.Surname,
				Patronymic = this.Patronymic
			};
		}

		public void Accept(Employee emp)
		{
			Name = emp.Name;
			Surname = emp.Surname;
			Patronymic = emp.Patronymic;
		}

		// This entity doesn't know about its relative objects
		//public int AddressId { get; set; }
		//public int BankAccId { get; set; }
	}
}
