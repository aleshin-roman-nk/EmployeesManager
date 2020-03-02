using EmModel.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class WorkDocumentEx
	{
		public Employee Employee { get; set; }
		public WorkDocument WorkDocument { get; set; }
		public BankAcc BankAcc { get; set; }
		public Business Business { get; set; }
	}
}
