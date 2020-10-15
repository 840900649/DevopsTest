using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevopsTest.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevopsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService userInfoService;
        public UserInfoController(IUserInfoService userInfoService)
        {
            this.userInfoService = userInfoService;
        }
        [HttpGet]
        public string GetUserName()
        {
            return userInfoService.GetUserName();
        }
        [HttpGet("{id}")]
        public string GetUserName(string id)
        { 
            return userInfoService.GetUserNameById(id);
        }
    }
}
