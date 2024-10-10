using ApplicationTier.Dtos;

namespace ApplicationTier.Interfaces
{
    public interface ICustomerMethods
    {
        Task<CustomerDto> AddCustomer(string firstName, string lastName, DateTime? dateOfBirth);

        Task<CustomerDto> GetCustomer(int CustomerId);
    }
}
