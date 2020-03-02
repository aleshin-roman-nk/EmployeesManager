using DocBuilder;
using EmModel.DbAccess;
using EmModel.Entities;
using EmModel.Entities.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmModel.Models
{
	public class UIEmployeesModel
	{
		public UIEmployee CreateEmployee()
		{
			var o = new UIEmployee
			{
				Address = new Address(),
				Employee = new Employee(),
				BankAcc = new BankAcc(),
				Passport = new Passport(),
				Business = new Business()
			};

			o.Passport.BornDay = DateTime.Today;
			o.Passport.PassportDate = DateTime.Today;
			o.Business.OGRNIP_DATE = DateTime.Today;
			o.Business.ContractDate = DateTime.Today;
			o.Business.ContractDuring = 12;

			return o;
		}

		public void RemoveEmployee(UIEmployee empl)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(empl.Employee).State = EntityState.Deleted;
				db.Entry(empl.Address).State = EntityState.Deleted;
				db.Entry(empl.BankAcc).State = EntityState.Deleted;
				db.Entry(empl.Passport).State = EntityState.Deleted;
				db.Entry(empl.Business).State = EntityState.Deleted;

				db.SaveChanges();
			}
		}

		public void StoreEmployee(UIEmployee empl)
		{
			using (DbAppData db = new DbAppData())
			{
				db.Entry(empl.Employee).State = getes(empl.Employee.Id);
				db.SaveChanges();

				db.Entry(empl.Address).State = getes(empl.Address.Id);
				db.Entry(empl.BankAcc).State = getes(empl.BankAcc.Id);
				db.Entry(empl.Passport).State = getes(empl.Passport.Id);
				db.Entry(empl.Business).State = getes(empl.Business.Id);

				empl.Address.EmployeeId = empl.Employee.Id;
				empl.BankAcc.EmployeeId = empl.Employee.Id;
				empl.Passport.EmployeeId = empl.Employee.Id;
				empl.Business.EmployeeId = empl.Employee.Id;

				db.SaveChanges();
			}
		}

		private EntityState getes(int id)
		{
			return id == 0 ? EntityState.Added : EntityState.Modified;
		}

		public IEnumerable<UIEmployee> GetUIEmployees()
		{
			using (DbAppData db = new DbAppData())
			{
				var employees = db.Employees.Select(x => new UIEmployee { Employee = x }).ToList();

				foreach (var employee in employees)
				{
					employee.Address = db.Addresses.First(x => x.EmployeeId == employee.Employee.Id);
					employee.Business = db.Businesses.First(x => x.EmployeeId == employee.Employee.Id);
					employee.Passport = db.Passports.First(x => x.EmployeeId == employee.Employee.Id);
					employee.BankAcc = db.BankAccs.First(x => x.EmployeeId == employee.Employee.Id);
				}

				return employees;
			}
		}
		public string GenerateContracts(IEnumerable<UIEmployee> empls, string htmlTemplate)
		{
			string res = "";

			foreach (var item in empls)
			{
				res += GenerateHTML(item, htmlTemplate);
			}

			return res;
		}

		string GenerateHTML(UIEmployee emp, string htmlTemplate)
		{
			Dictionary<string, string> table = Map(emp);

			DBiuld doc = new DBiuld(table, htmlTemplate);

			return doc.Document;
		}

		Dictionary<string, string> Map(UIEmployee emp)
		{
			var table = new Dictionary<string, string>();

			table["contract_no"] = emp.Business.ContractNo;
			table["contract_date"] = emp.Business.ContractDate.ToString("dd-MM-yyyy");
			table["fio"] = emp.FullName;
			table["ogrnip_no"] = emp.Business.OGRNIP;
			table["ogrnip_issued_date"] = emp.Business.OGRNIP_DATE.ToString("dd-MM-yyyy");
			table["ogrnip_issued_organ"] = emp.Business.OGRNIPIssuedBy;
			table["contract_date_end"] = emp.Business.ContractDateEnd.ToString("dd-MM-yyyy"); ;
			table["addr_index"] = emp.Address.Postcode;
			table["addr_city"] = emp.Address.City;
			table["addr_street"] = emp.Address.Street;
			table["addr_home_no"] = emp.Address.Building;
			table["addr_home_box_no"] = emp.Address.Apartment;
			table["inn"] = emp.Business.INN;
			table["bank_bik"] = emp.BankAcc.BIK;
			table["bank_account_no"] = emp.BankAcc.Accaunt;
			table["passp_no"] = emp.Passport.SerialNumber;
			table["passp_issued_organ"] = emp.Passport.IssuedBy;
			table["passp_issued_date"] = emp.Passport.PassportDate.ToString("dd-MM-yyyy");
			table["fio_short"] = emp.ShortName;

			return table;
		}
	}
}
