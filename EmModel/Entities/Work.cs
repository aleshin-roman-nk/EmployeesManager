using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Entities
{
	/*
	 * Добавить Tag для возможности подсчитывать единицы работы по группам.
	 *		Например подсчитывать количество подработок и сопоставлять с общим количеством замещений
	 * 
	 */
	public class Work
	{
		public int Id { get; set; }
		public int WorkDocumentId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal Sum { get => Price * Count; }

		public Work Clone()
		{
			return new Work
			{
				Name = Name,
				Description = Description,
				Price = Price,
				Count = Count
			};
		}

		public void Accept( Work work )
		{
			this.Name = work.Name;
			this.Price = work.Price;
			this.Count = work.Count;
			this.Description = work.Description;
		}
	}
}
