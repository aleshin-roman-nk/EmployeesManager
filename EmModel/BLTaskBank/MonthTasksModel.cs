using EmModel.BLTaskBank.CalcModules;
using EmModel.BLTaskBank.Entities;
using EmModel.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>>
 * 04-04-2020 19-28
 * Функционал вычислительного блока.
 * !!!Важное замечание: работа не может быть выполнена без задачи. (Хотя может, например компенсация за какую то покупку)
 *      Т.е. каждая работа документа должна быть на основании задачи.
 *      Ставится задача, устанавливается бюджет.
 * Сущность с коллекцией ежемесячных задач. Шаблон.
 * 
 * 
 * 1. Продсчет смен в указанный месяц каждой бригады
 * 2. 
 * 
 * 
 */

namespace EmModel.BLTaskBank
{
	public class MonthTasksModel
	{
        public IEnumerable<MonthWorkPosition> GetMonthWorkPositions(int year, int month)
        {
            using (DbAppData db = new DbAppData())
            {
                var res = db.MonthWorkPositions.ToList();

                MonthCalendar monthCalendar = new MonthCalendar(year, month);

                foreach (var item in res)
                    item.ShiftAmout = monthCalendar.GetDayAmountOfRange(item.Days.ToArray());

                return res;
            }
        }
        public void SavePosition(MonthWorkPosition pos)
        {
            using (DbAppData db = new DbAppData())
            {
                db.Entry(pos).State = pos.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
	}
}
