using ProductBecho.BO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductBecho.BAL.Interface
{
    public interface IUserBL
    {
        Task<bool> CheckUserExists(UserBO user);
        Task CreateUser(UserBO user);
    }
}
