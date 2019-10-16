using ProductBecho.BAL.Interface;
using ProductBecho.BO;
using ProductBecho.DAL.Implement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ProductBecho.BAL.Implement
{
    public class UserBL : IUserBL
    {
        private UserDL userDL;
        public UserBL(IServiceProvider serviceProvider)
        {
            IConfiguration config = serviceProvider.GetRequiredService<IConfiguration>();
            this.userDL = new UserDL(config.GetConnectionString("SqlServer"));

        }
        public async Task<bool> CheckUserExists(UserBO user)
        {
            if (await userDL.GetUser(user.Email) != null)
            {
                return true;
            }
            return false;
        }

        public async Task CreateUser(UserBO user)
        {
            await userDL.CreateUser(user);
        }
    }
}
