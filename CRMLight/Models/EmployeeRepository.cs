using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMLight.Models
{

        public interface IEmployeeRepository
        {
            IEnumerable<Employee> GetAllEmployees();
            Employee GetEmployee(int id);
            void AddEmployee(Employee employee);
            void Remove(int id);
            bool Update(Employee employee);
        }
        public class EmployeeRepository : IEmployeeRepository
        {
            private readonly CRMLightEntities _db;

            public EmployeeRepository()
            {
                _db = new CRMLightEntities();
            }

            public IEnumerable<Employee> GetAllEmployees()
            {
                return _db.Employees;
            }

            public Employee GetEmployee(int id)
            {
                return _db.Employees.Find(id);
            }

            public void AddEmployee(Employee employee)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                //return employee;
            }

            public void Remove(int id)
            {
                Employee employee = _db.Employees.Find(id);
                _db.Employees.Remove(employee);
                _db.SaveChanges();
            }

            public bool Update(Employee employee)
            {
                Employee newEmployee = _db.Employees.Find(employee.ID);
                if (newEmployee == null)
                    return false;
                newEmployee.Company = employee.Company;
                newEmployee.FirstName = employee.FirstName;
                newEmployee.LastName = employee.LastName;
                newEmployee.Email = employee.Email;
                newEmployee.JobTitle = employee.JobTitle;
                newEmployee.LastName = employee.LastName;
                newEmployee.Email = employee.Email;
                newEmployee.JobTitle = employee.JobTitle;
                newEmployee.WorkPhone = employee.WorkPhone;
                newEmployee.HomePhone = employee.HomePhone;
                newEmployee.MobilePhone = employee.MobilePhone;
                newEmployee.Fax = employee.Fax;

                newEmployee.Website = employee.Website;
                newEmployee.Notes = employee.Notes;
                _db.SaveChanges();
                return true;

            }
        }
    }
