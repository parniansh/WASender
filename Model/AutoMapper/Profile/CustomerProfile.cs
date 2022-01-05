﻿using AutoMapper;
using Model.Model;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerActionDto, Customer>();
            CreateMap<Customer,CustomerActionDto > ();


        }
    }
}
