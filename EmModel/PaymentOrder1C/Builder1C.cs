using EmModel;
using EmModel.Entities;
using EmModel.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentOrder1C
{
	public class Builder1C
	{
		public Builder1C Build(IEnumerable<WorkDocumentEx> documents, WorkDocumentEx payer, int firstNo)
		{

			foreach (var doc in documents)
			{
				//Add(payer, pr, DocNo, pr.Sum?.ToString("f2").Replace(',', '.'), DateTime.Today.ToShortDateString());
				Add(doc, payer, ++firstNo);
			}

			return this;
		}
		public new string ToString()
		{
			string s = "1CClientBankExchange" + Environment.NewLine + Environment.NewLine;
			foreach (var item in PayDocList)
			{
				s += item.ToString();
			}
			return s;
		}
		private List<PayDocument> PayDocList { get; set; } = new List<PayDocument>();

		private void Add(WorkDocumentEx receiver, WorkDocumentEx payer, int docNo)
		{
			PayDocument pd = new PayDocument();

			var sum = receiver.WorkDocument.TotalSum.ToString("f2").Replace(',', '.');

			pd.SetValue(PayDocumentValues.Number, docNo.ToString());
			pd.SetValue(PayDocumentValues.Date, DateTime.Today.ToShortDateString());
			pd.SetValue(PayDocumentValues.Sum, sum);
			pd.SetValue(PayDocumentValues.PayerAccount, payer.BankAcc.Accaunt);
			pd.SetValue(PayDocumentValues.PayerName, "ИП " + payer.Employee.FullName);
			pd.SetValue(PayDocumentValues.PayerINN, payer.Business.INN);
			pd.SetValue(PayDocumentValues.PayerKPP, "0");
			pd.SetValue(PayDocumentValues.PayerAccount1, payer.BankAcc.Accaunt);
			pd.SetValue(PayDocumentValues.PayerBankName, payer.BankAcc.BankName);
			pd.SetValue(PayDocumentValues.PayerBankBIK, payer.BankAcc.BIK);
			pd.SetValue(PayDocumentValues.PayerCorrAcc, payer.BankAcc.BankCorrAcc);
			pd.SetValue(PayDocumentValues.ReceiverAccount, receiver.BankAcc.Accaunt);
			pd.SetValue(PayDocumentValues.ReceiverName, "ИП " + receiver.WorkDocument.Employee.FullName);
			pd.SetValue(PayDocumentValues.ReceiverINN, receiver.Business.INN);
			pd.SetValue(PayDocumentValues.ReceiverKPP, "0");
			pd.SetValue(PayDocumentValues.ReceiverAccount1, receiver.BankAcc.Accaunt);
			pd.SetValue(PayDocumentValues.ReceiverBankName, receiver.BankAcc.BankName);
			pd.SetValue(PayDocumentValues.ReceiverBIK, receiver.BankAcc.BIK);
			pd.SetValue(PayDocumentValues.ReceiverCorrAcc, receiver.BankAcc.BankCorrAcc);
			pd.SetValue(PayDocumentValues.PayWay, "электронно");
			pd.SetValue(PayDocumentValues.PayWay1, "01");
			pd.SetValue(PayDocumentValues.Priority, "5");
			pd.SetValue(PayDocumentValues.PayPurpose,
				$"Оплата по акту №{receiver.WorkDocument.No} от {receiver.WorkDocument.Date.ToString("dd.MM.yyyy")} сдачи-приемки работ," +
				$" выполненных по договору №{receiver.Business.ContractNo} от {receiver.Business.ContractDate.ToString("dd.MM.yyyy")}. Без налога (НДС)");

			PayDocList.Add(pd);
		}
	}
}
