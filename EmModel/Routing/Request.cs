using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Routing
{
	public class Request
	{
		public string Req { get; set; }
		public Dictionary<string, string> Params { get; set; }
		public object Responce { get; set; }
		public string ResponceType { get; set; }
		public bool Success { get; set; } = false;
		public string Message { get; set; }
	}
}
