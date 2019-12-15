using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 05-10-2019
 * 
 * >>>
 * Написать генератор sql-запросов создания таблиц для sqlite на основе сущности.
 * Или генерация и класса сущности и sql запроса по набору полей сущности.
 * 
 * 13-10-2019
 * >>>
 * Можно писать в виде JSON формата описание сущности класса, по которому генерируется класс и sql-запрос создания таблицы
 * 
 * 
 * 
 */

namespace EmModel.Entities
{
	public class WorkType
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal Sum { get => Price * Count; }
	}
}
