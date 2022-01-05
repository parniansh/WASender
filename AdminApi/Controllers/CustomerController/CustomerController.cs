using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModel;
using Service.CustomerService;

namespace AdminApi.Controllers.CustomerController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]


    public class CustomerController : ControllerBase

    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) 
        {
            _customerService = customerService;
        }

        

        

        // POST: CustomerController/Create
        [HttpPost("CreateCustomer")]
        //[ValidateAntiForgeryToken]
        public async Task<int> CreateCustomer(CustomerActionDto input)
        {
            
            return await _customerService.CreateCustomer(input);
        }

        

        


        
    }
}
