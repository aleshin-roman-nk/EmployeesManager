using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class Business
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string INN { get; set; }
		public string OGRNIP { get; set; }
		public string OGRNIPIssuedBy { get; set; }
		public DateTime OGRNIP_DATE { get; set; }
		public string ContractNo { get; set; }
		public DateTime ContractDate { get; set; }
		public int ContractDuring { get; set; }
		public DateTime ContractDateEnd { get => ContractDate.AddMonths(ContractDuring); }
		public Business Clone()
		{
			return new Business
			{
				INN = INN,
				OGRNIP = OGRNIP,
				OGRNIPIssuedBy = OGRNIPIssuedBy,
				OGRNIP_DATE = OGRNIP_DATE,
				ContractNo = ContractNo,
				ContractDuring = ContractDuring,
				ContractDate = ContractDate
			};
		}
		public void Accept(Business src)
		{
			INN = src.INN;
			OGRNIP = src.OGRNIP;
			OGRNIPIssuedBy = src.OGRNIPIssuedBy;
			OGRNIP_DATE = src.OGRNIP_DATE;
			ContractNo = src.ContractNo;
			ContractDate = src.ContractDate;
			ContractDuring = src.ContractDuring;
		}
	}
}
