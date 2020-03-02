using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmModel.Entities.UI
{
	/*
	 * Создаем сразу комплексом
	 * Т.е. создавая работника, создаются сразу все сущности, связанные с ним
	 *		Например сущность паспорта, но пустая, которую нежно заполнять.
	 *		Нет смысла потом прикреплять другие. Т.к. Паспорт и есть паспорт.
	 * 
	 * 
	 */

	/*
	 * >>>
	 * 28-02-2020
	 * Я понял, что не нужно делать отдельно UI сущность, по крайней мере в этом проекте.
		 *	Лучше сегментировать, т.е. просто сущность Employee и в ней разделы Address.
	 *	Лучше сегментировать, т.е. просто сущность Employee и в ней разделы Address, BankAcc и т.д.
	 * 
	 * 
	 */

	public class UIEmployee
	{
		public Employee Employee { get; set; }
		public Address Address { get; set; }
		public BankAcc BankAcc { get; set; }
		public Passport Passport { get; set; }
		public Business Business { get; set; }
		public string Name { get => Employee?.Name; }
		public string Surname { get => Employee?.Surname; }
		public string Patronymic { get => Employee?.Patronymic; }
		public string FullName { get => $"{Surname} {Name} {Patronymic}"; }
		public string ShortName { get => $"{Surname} {Name[0]}. {Patronymic[0]}"; }
	}
}
