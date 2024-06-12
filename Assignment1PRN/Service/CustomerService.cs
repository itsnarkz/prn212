using Assignment1PRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.Service
{
    public class CustomerService
    {
        public CustomerService() { }
        public List<Customer> GetAll() { return FuminiHotelManagementContext.Instance().Customers.ToList(); }
        public bool HasCustomer(String email, String password) {
            return GetAll().Any(c => c.EmailAddress .Equals(email)  && c.Password.Equals(password));
        }
        public Customer GetCustomer(String email, String password)
        {
            return GetAll().Where(c => c.EmailAddress .Equals(email)  && c.Password.Equals(password)).ToList()[0];
        }

        public void UpdateCustomer(int id,String name, String telephone, String mail, DateOnly? birthday, int status = 10)
        {
            Customer c = FuminiHotelManagementContext.Instance().Customers.Find(id);
            if (c == null) return;
            c.CustomerFullName = name;
            c.EmailAddress = mail;
            c.Telephone = telephone;
            c.CustomerBirthday = birthday;
            if (status != 10)
                c.CustomerStatus = (byte)status;
            FuminiHotelManagementContext.Instance().SaveChanges();
        }
        public void DeleteCustomer(int id) {
            Customer c = FuminiHotelManagementContext.Instance().Customers.Find(id);
            if(c == null) return;
            FuminiHotelManagementContext.Instance().Customers.Remove(c);
            FuminiHotelManagementContext.Instance().SaveChanges();
        }

        public Customer GetById(int id)
        {
            return FuminiHotelManagementContext.Instance().Customers.Find(id);
        }
    }
}
