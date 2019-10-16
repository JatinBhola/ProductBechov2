using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductBecho.BO;
using ProductBecho.DE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ProductBecho.DAL.Implement
{
    public class UserDL
    {
        private IServiceProvider serviceProvider;
        private ProductBechoContext context;
        public UserDL(String connectionString)
        {
            var optionBuilder = new DbContextOptionsBuilder<ProductBechoContext>();
            optionBuilder.UseSqlServer(connectionString);
            this.context = new ProductBechoContext(optionBuilder.Options);
        }
        public Task CreateUser(UserBO userBO)
        {
            throw new NotImplementedException();
        }

        public Task<UserBO> GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}
