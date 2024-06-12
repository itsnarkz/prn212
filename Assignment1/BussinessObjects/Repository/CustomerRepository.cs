using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Models;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerByEmail(string email)
        {
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    return context.Customers.SingleOrDefault(s => s.EmailAddress == email);
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    Console.WriteLine($"Error retrieving customer: {ex.Message}");
                    return null; // Return null or throw the exception based on your requirement
                }
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
