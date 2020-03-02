using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel
{
	public static class LOG_CLASS
	{
		public static void Log(string text)
		{
			File.AppendAllText("error.txt", text, Encoding.UTF8);
		}

		public static string Ser(object o)
		{
			return JsonConvert.SerializeObject(o, Formatting.Indented);
		}
	}
}
