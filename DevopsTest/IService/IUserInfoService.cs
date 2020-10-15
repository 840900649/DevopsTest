using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsTest.IService
{
   public interface IUserInfoService
    {
        string GetUserName();
        string GetUserNameById(string id);
    }
}
