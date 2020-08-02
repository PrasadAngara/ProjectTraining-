using APIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Repositories
{
    public class EmployeeRepository
    {
        //Get All Employees
        public List<Employee> GetAll()
        {
            using (EmployeeManagementContext db = new EmployeeManagementContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get Employee By Id
        public Employee GetById(string EmpId)
        {
            using (EmployeeManagementContext db = new EmployeeManagementContext())
            {
                return db.Employee.Find(EmpId);
            }
        }
        //Add Employee
        public void Add(Employee employee)
        {
            using (EmployeeManagementContext db = new EmployeeManagementContext())
            {
                db.Employee.Add(employee);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(string EmpId)

        {
            using (EmployeeManagementContext db = new EmployeeManagementContext())
            {
                Employee e = db.Employee.Find(EmpId);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee employee)
        {
            using (EmployeeManagementContext db = new EmployeeManagementContext())
            {
                db.Employee.Update(employee);
                db.SaveChanges();
            }
        }

    }
}
