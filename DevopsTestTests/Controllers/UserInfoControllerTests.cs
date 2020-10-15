using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevopsTest.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using DevopsTest.IService;
using Moq;
using DevopsTest.Models;
using DevopsTest.Service;
using DevopsTestTests;

namespace DevopsTest.Controllers.Tests
{
    [TestClass()]
    public class UserInfoControllerTests: TestBase
    {
        [TestMethod()]
        public void GetUserNameTest()
        {
            var userInfoService = new Mock<IUserInfoService>();
            userInfoService.Setup(s => s.GetUserNameById(It.IsAny<string>())).Returns("张三---");
            userInfoService.Setup(s => s.GetUserName()).Returns("张三");
            var controller = new UserInfoController(userInfoService.Object);

           // var controller = new UserInfoController(new UserInfoService());

            var result = controller.GetUserName();
            Assert.IsNotNull(result); 

            var result2 = controller.GetUserName("1123"); 
            Assert.IsNotNull(result2); 
        }
         
    }
}