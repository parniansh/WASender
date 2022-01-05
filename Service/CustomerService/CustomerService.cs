using Model.ViewModel;
using Repository.CustomerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo) 
        { 
            _customerRepo = customerRepo;
        }
        public async Task<int> CreateCustomer(CustomerActionDto input) 
        {
            return await _customerRepo.CreateCustomerAsync(input);
        }
    }
}
