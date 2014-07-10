using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMLight.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        Customer Add(Customer item);
        void Remove(int id);
        bool Update(Customer item);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CRMLightEntities _db;

        public CustomerRepository()
        {
            _db = new CRMLightEntities();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _db.Customers;
        }

        public Customer Get(int id)
        {
            return _db.Customers.Find(id);
        }

        public Customer Add(Customer customer)
        {
           
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return customer;
   
        }

        public void Remove(int id)
        {
            Customer customer = _db.Customers.Find(id);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }

        public bool Update(Customer customer)
        {
            Customer newCustomer = _db.Customers.Find(customer.ID);
            if (newCustomer == null)
                return false;

            newCustomer.Company = customer.Company;
            newCustomer.FirstName = customer.FirstName;
            newCustomer.LastName = customer.LastName;
            newCustomer.Email = customer.Email;
            newCustomer.JobTitle = customer.JobTitle;
            newCustomer.LastName = customer.LastName;
            newCustomer.Email = customer.Email;
            newCustomer.JobTitle = customer.JobTitle;
            newCustomer.WorkPhone = customer.WorkPhone;
            newCustomer.HomePhone = customer.HomePhone;
            newCustomer.MobilePhone = customer.MobilePhone;
            newCustomer.Fax = customer.Fax;

            newCustomer.Website = customer.Website;
            newCustomer.Notes = customer.Notes;
            _db.SaveChanges();
            return true;
        }

    }
}
