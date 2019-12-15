using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8900 054 4590 тел Игнатова Саши
namespace EmModel.Entities.UI
{
	public class UIEmployee
	{
		public Employee Employee { get; set; }
		public Address Address { get; set; }
		public BankAcc BankAcc { get; set; }
		public string Name { get => Employee?.Name; }
		public string Surname { get => Employee?.Surname; }
		public string Patronymic { get => Employee?.Patronymic; }
		public string FullName { get => $"{Surname} {Name} {Patronymic}"; }
		public string ShortName { get => $"{Surname} {Name[0]}. {Patronymic[0]}"; }
	}
}
