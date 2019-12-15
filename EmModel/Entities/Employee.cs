using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Не нужно брать коллекцию номеров актов брать из базы.
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
		public string INN { get; set; }
		// This entity doesn't know about its relative objects
		//public int AddressId { get; set; }
		//public int BankAccId { get; set; }
	}
}
