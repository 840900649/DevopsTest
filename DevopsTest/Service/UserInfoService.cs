using DevopsTest.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsTest.Service
{
    public class UserInfoService : IUserInfoService
    {
        public string GetUserName()
        {
            return "张三";
        }

        public string GetUserNameById(string id)
        { 
            return "张三---"+id;
        }
    }
}
