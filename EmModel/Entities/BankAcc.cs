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
	}
}
