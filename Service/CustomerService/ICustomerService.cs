﻿using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CustomerService
{
    public interface ICustomerService
    {
        Task<int> CreateCustomer(CustomerActionDto input);
    }
}
