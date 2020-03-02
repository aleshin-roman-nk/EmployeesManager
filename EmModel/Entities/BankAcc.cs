using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class BankAcc
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string BankName { get; set; }
		public string BankCorrAcc { get; set; }
		public string Accaunt { get; set; }
		public string BIK { get; set; }
		public void FromBank(Bank bank)
		{
			BankName = bank.Name;
			BankCorrAcc = bank.CorrAcc;
			BIK = bank.BIK;
		}
		public BankAcc Clone()
		{
			return new BankAcc
			{
				BankName = BankName,
				BankCorrAcc = BankCorrAcc,
				Accaunt = Accaunt,
				BIK = BIK
			};
		}
		public void Accept(BankAcc src)
		{
			BankName = src.BankName;
			BankCorrAcc = src.BankCorrAcc;
			Accaunt = src.Accaunt;
			BIK = src.BIK;
		}
	}
}
