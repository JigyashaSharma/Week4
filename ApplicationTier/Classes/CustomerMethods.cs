using IndustryConnect_Week_Microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationTier.Dtos;
using Microsoft.EntityFrameworkCore;
using ApplicationTier.Interfaces;

namespace ApplicationTier.Classes
{
    public class CustomerMethods : ICustomerMethods
    {

        public CustomerMethods() { }

        public async Task<CustomerDto> AddCustomer(string firstName, string lastName, DateTime? dateOfBirth)
        {
            var context = new IndustryConnectWeek2Context();

            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth
            };

            context.Add(customer);

            await context.SaveChangesAsync();
        
            return Mapper(customer);
       
        }

        public async Task<CustomerDto> GetCustomer(int CustomerId)
        {
            var context = new IndustryConnectWeek2Context();

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.Id == CustomerId);

            return Mapper(customer);
        }


        private static CustomerDto Mapper(Customer? customer)
        {
            if (customer != null)
            {
                var customerDto = new CustomerDto
                {
                    FirstName = customer?.FirstName,
                    LastName = customer?.LastName,
                    DateOfBirth = customer?.DateOfBirth,
                    Id = customer.Id
                };

                return customerDto;
            }
            else
            {
                return null;
            }
           
        }

    }
}
