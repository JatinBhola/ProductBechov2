using AutoMapper;
using ProductBecho.BO;
using ProductBecho.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBecho.API
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<UserVM, UserBO>();
        }
    }
}
