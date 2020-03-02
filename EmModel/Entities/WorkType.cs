using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	public class WorkType
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal Sum { get => Price * Count; }

        public Work CreateWork()
        {
            return new Work
            {
                Count = 1,
                Name = Name,
                Price = Price
            };
        }
	}
}
