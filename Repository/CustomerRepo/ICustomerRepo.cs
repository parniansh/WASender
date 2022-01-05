using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CustomerRepo
{
    public interface ICustomerRepo
    {
        Task<int> CreateCustomerAsync(CustomerActionDto input);
    }
}
