using AutoMapper;
using Model;
using Model.Model;
using Model.ViewModel;
using Repository.CustomerRepo;


namespace Repository.CustomerRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _dbContext;


        public CustomerRepo(IMapper mapper, AppDBContext dbcontext) 
        {
            _mapper = mapper;
            _dbContext = dbcontext;
        }
        public async Task<int> CreateCustomerAsync(CustomerActionDto input) 
        {
            var userId = _dbContext.getCurrentUserID();
            input.applicationUserId = userId;
            var customer = new Customer();
           _mapper.Map(input,customer );
            _dbContext.Add(customer);
            await _dbContext.SaveChangesAsync();
            return customer.Id;
        }

    }
}
