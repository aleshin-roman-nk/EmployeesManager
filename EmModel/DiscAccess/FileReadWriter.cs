using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.DiscAccess
{
	public static class FileReadWriter
	{
		public static void WriteAllText(string filename, string body)
		{
			File.WriteAllText(filename, body, Encoding.UTF8);
		}
	}
}
