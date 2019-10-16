using ProductBecho.BAL.Interface;
using ProductBecho.BO;
using ProductBecho.DAL.Implement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductBecho.BAL.Implement
{
    public class UserBL : IUserBL
    {
        private UserDL userDL;
        public UserBL(IServiceProvider serviceProvider)
        {
            this.userDL = new UserDL(serviceProvider);

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
