using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentOrder1C
{
	internal class PayDocument
	{
		public new string ToString()
		{
			string nl = Environment.NewLine;

			string resultStr = nl + "СекцияДокумент=Платежное поручение" + nl;

			foreach (var item in Values.Keys)
			{
				if (Values.ContainsKey(item))
					resultStr += $"{item}={Values[item]}{nl}";
				else
					resultStr += $"{item}={nl}";
			}
			resultStr += "КонецДокумента" + nl;

			return resultStr;
		}

		public void SetValue(string key, string value)
		{
			Values.Add(key, value);
		}

		// 1: имя в документе 2: значение
		Dictionary<string, string> Values { get; } = new Dictionary<string, string>();

		//Оплата по акту от 06.02.2018 сдачи-приемки работ, выполненных по договору №53 от 1 мая 2017г.НДС не облагается
	}
}
