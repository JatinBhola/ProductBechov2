
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBecho.VM;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using AutoMapper;
using ProductBecho.BO;
using ProductBecho.BAL.Interface;

namespace ProductBecho.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IMapper mapper;
        IUserBL userBL;
        public UserController(IMapper mapper,IUserBL userBL)
        {
            this.mapper = mapper;
            this.userBL = userBL;
        }
        [Route("api/user/signup")]
        [HttpPost]
        public async Task<ActionResult<UserVM>> SignUp(UserVM user)
        {
            UserBO userBO = mapper.Map<UserVM, UserBO>(user);
            bool userExists = await userBL.CheckUserExists(userBO);
            if (userExists)
            {
                return Conflict(new { message = "User already exists" });
            }
            await userBL.CreateUser(userBO);
            return user;
        }
    }
}