using EmModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Forms.MainForm.InternalUILogic
{
	/*
	 * Логика представления данных, хранение текущих видов.
	 *	Эта ответственность по разумной причине, в слое UI
	 *		Это НЕ логика модели данных. В любом случае view должен владеть информацией о текущих видах и что запросить в контроллера
	 */

		/// <summary>
		/// Логика Year.Month.WorkDocument.Work
		/// При установке родителя, сбрасываются дети
		/// View может свою структуру данных для удобной работы. Очевидно, для этого отдельный класс-механизм.
		/// </summary>
	public class CurrentObjects
	{
		public Year Year { get; set; } = null;
		public Month Month { get; set; } = null;
		public WorkDocument WorkDocument { get; set; } = null;
		public Work Work { get; set; } = null;
	}
}